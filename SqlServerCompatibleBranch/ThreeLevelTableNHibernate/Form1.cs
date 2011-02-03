using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThreeLevelTableNHibernate.TheServiceReference;

namespace ThreeLevelTableNHibernate
{
    public partial class Form1 : Form
    {
        TheServiceReference.ServiceClient _service = null;

        public Form1()
        {
            _service = new TheServiceReference.ServiceClient();
            InitializeComponent();
        }

        private void uxNew_Click(object sender, EventArgs e)
        {
            Question qx = _service.NewQuestion();
            qx.Answers = new List<Answer>();
            qx.Comments = new List<QuestionComment>();
            bdsQuestion.DataSource = qx;
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            commentsBindingSource.EndEdit();
            answersBindingSource.EndEdit();
            bdsQuestion.EndEdit();


            var q = (Question)bdsQuestion.Current; 
            int n = _service.SaveQuestion(q);            
            q.QuestionId = n;

            this.Text = n.ToString();

            MessageBox.Show("Saved.");
        }

        private void uxOpen_Click(object sender, EventArgs e)
        {

            
            bdsQuestion.DataSource = _service.OpenQuestion(Convert.ToInt32(textBox1.Text));

            this.Text = ((Question)bdsQuestion.Current).QuestionId.ToString();
        }

        private void commentsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (commentsBindingSource.Current == null) return;

            var qc = (QuestionComment)commentsBindingSource.Current;

            if (qc.Question == null)            
                qc.Question = (Question)bdsQuestion.Current;
        }

        private void answersBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (answersBindingSource.Current == null) return;

            var a = (Answer)answersBindingSource.Current;

            if (a.Question == null)
            {
                a.Question = (Question)bdsQuestion.Current;
                a.Comments = new List<AnswerComment>();                                
            }

            answersCommentBindingSource.DataSource = a.Comments;
        }

        private void answersCommentBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (answersCommentBindingSource.Current == null) return;

            var c = (AnswerComment)answersCommentBindingSource.Current;

            if (c.Answer == null)
                c.Answer = (Answer)answersBindingSource.Current;
        }

        private void answersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (answersBindingSource.Current == null) return;

            var a = (Answer)answersBindingSource.Current;

            answersCommentBindingSource.DataSource = a.Comments;

         
        }



        private void button1_Click(object sender, EventArgs e)
        {
            _service.SaveTheQuestion();
            MessageBox.Show("OK");
        }


    }
}
