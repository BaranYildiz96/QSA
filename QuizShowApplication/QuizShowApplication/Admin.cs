using System;
using System.Collections.Generic;
using System.Text;

namespace QuizShowApplication
{
    public class Admin : Participant
    {
         public int userName
        {
            get => default;
            set
            {
            }
        }

        private int password
        {
            get => default;
            set
            {
            }
        }

        private int userID
        {
            get => default;
            set
            {
            }
        }

        public void addQuestion()
        {
            throw new System.NotImplementedException();
        }

        public void updateQuestion()
        {
            throw new System.NotImplementedException();
        }

        public void deleteQuestion()
        {
            throw new System.NotImplementedException();
        }

        public void seeQuestion()
        {
            throw new System.NotImplementedException();
        }

        public void showResult()
        {
            throw new System.NotImplementedException();
        }
    }
}