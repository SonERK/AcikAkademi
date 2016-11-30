using Ders4.Helper;
using Ders4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Ders4.Views
{
    public partial class UpdatePage : ContentPage
    {
        SQLiteManager _manager = new SQLiteManager();
        Student _student = new Student();

        public UpdatePage(Student student)
        {
            InitializeComponent();

            _student = student;

            SetStudentInfo();
        }

        void SetStudentInfo()
        {
            txtName.Text = _student.Name;
            txtSurname.Text = _student.Surname;
        }

        private void onUpdate(object sender, EventArgs e)
        {
            _student.Name = txtName.Text;
            _student.Surname = txtSurname.Text;

            DisplayAlert(_manager.Update(_student) ?"Güncellendi":"Güncellenemedi !", _student.Name , "OK");

        }
    }
}
