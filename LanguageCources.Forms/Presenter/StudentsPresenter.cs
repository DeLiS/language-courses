using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LanguageCources.Forms.DataTransferObjects;
using LanguageCources.Forms.Validators;
using LanguageCourses.BusinessLayer.DomainObjects;
using LanguageCourses.BusinessLayer.Interfaces;
using LanguageCourses.Forms.Forms;

namespace LanguageCources.Forms.Presenter
{
    class StudentsPresenter
    {
        private const string HeaderFirstNameText = "First Name";
        private const string HeaderLastNameText = "Last Name";
        private const string HeaderPhoneNumberText = "Phone Number";
        private readonly IServiceFactory _serviceFactory;
        private readonly IStudentService _studentService;
        private StudentsForm _form;
        private List<StudentCard> _studentsInGrid;
        private Dictionary<Guid, long> _studentIds = new Dictionary<Guid, long>();
        private bool _handleEvents = true;

        public StudentsPresenter(IServiceFactory serviceFactory)
        {
            if (serviceFactory == null)
            {
                throw new ArgumentNullException("serviceFactory");
            }

            _serviceFactory = serviceFactory;
            _studentService = _serviceFactory.GetStudentService();

        }

        public void Bind(StudentsForm form)
        {
            _form = form;
            _form.NudCount.ValueChanged += (sender, args) => InitGrid(_form);
            _form.NudOffset.ValueChanged += (sender, args) => InitGrid(_form);
            _form.TbFirstNameFilter.TextChanged += (sender, args) => InitGrid(_form);
            _form.TbLastNameFilter.TextChanged += (sender, args) => InitGrid(_form);

            _form.DgvStudents.CellValueChanged += OnStudentUpdate;
            _form.DgvStudents.CellValidating += OnStudentValidating;
            InitGrid(form);
        }

      
        private void InitGrid(StudentsForm form)
        {
            _handleEvents = false;
            var list = _studentService.FindByName(_form.TbFirstNameFilter.Text,
                _form.TbLastNameFilter.Text,
                Convert.ToInt64(_form.NudOffset.Value) - 1,
                Convert.ToInt32(_form.NudCount.Value));
            _studentsInGrid = list.Select(TransformToCard).ToList();

            var studentCards = new BindingList<StudentCard>(_studentsInGrid);

            form.Students = new BindingSource {DataSource = typeof(StudentCard)};
            form.Students.DataSource = studentCards;

            InitializeStudentsGrid(form);
            _handleEvents = true;
        }

        private void InitializeStudentsGrid(StudentsForm form)
        {
            form.DgvStudents.AutoGenerateColumns = true;
            form.DgvStudents.DataSource = form.Students;

            form.DgvStudents.Columns["ViewId"].Visible = false;
            form.DgvStudents.Columns["GroupId"].Visible = false;


            form.DgvStudents.Columns["FirstName"].HeaderText = HeaderFirstNameText;
            form.DgvStudents.Columns["LastName"].HeaderText = HeaderLastNameText;
            form.DgvStudents.Columns["PhoneNumber"].HeaderText = HeaderPhoneNumberText;

   
            form.DgvStudents.Refresh();
        }

        private StudentCard TransformToCard(Student s)
        {
            var result = new StudentCard
            {
                FirstName = s.FirstName, 
                LastName = s.LastName, 
                PhoneNumber = s.PhoneNumber
            };
            _studentIds[result.ViewId] = s.Id.Value;

            return result;
        }

        private void OnStudentValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!_handleEvents)
            {
                return;
            }
            DataGridView grid = sender as DataGridView;
            Guid viewId = (Guid) grid["ViewId", e.RowIndex].Value;
            StudentCard updatedStudent = _studentsInGrid.Find(s => s.ViewId.Equals(viewId));
            if (updatedStudent == null) return;
            StudentCard copy = updatedStudent.Clone() as StudentCard;
            switch (grid.Columns[e.ColumnIndex].HeaderText)
            {
                case HeaderFirstNameText:
                    copy.FirstName = e.FormattedValue.ToString();
                    break;
                case HeaderLastNameText:
                    copy.LastName = e.FormattedValue.ToString();
                    break;
                case HeaderPhoneNumberText:
                    copy.PhoneNumber = e.FormattedValue.ToString();
                    break;
            }

            IEnumerable<string> brokenRules;
            StudentCardValidator validator = new StudentCardValidator();
            e.Cancel = !copy.Validate(validator, out brokenRules);
            
            if (e.Cancel)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("The following rules are broken: ");
                foreach (var brokenRule in brokenRules)
                {
                    builder.AppendLine(brokenRule);
                }
                grid.CancelEdit();

                MessageBox.Show(_form, builder.ToString());
            }
        }

        private void OnStudentUpdate(object sender, DataGridViewCellEventArgs e)
        {
            if (!_handleEvents)
            {
                return;
            }
            Guid id = (Guid)_form.DgvStudents["ViewId", e.RowIndex].Value;

            StudentCard student = _studentsInGrid.Find(card => card.ViewId.Equals(id));
            _studentService.UpdateStudentData(new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                PhoneNumber = student.PhoneNumber,
                Id = GetId(id)
            });
            InitGrid(_form);
        }

        private long? GetId(Guid viewId)
        {
            return _studentIds[viewId];
        }
    }
}
