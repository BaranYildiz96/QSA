using System;
using System.Collections.Generic;
using System.Text;

namespace QuizShowApplication
{
    public class Participant
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

        public void LoginIn()
        {
            /*
           if (username==adminusername && passwaord==adminpassword)
           {
               // if admin can enter the admin window          
           }
           else if (username!==adminusername && passwaord!==adminpassword)
           {
               // if unic pariticipant can enter the new participant window 
              // answerQuestion();
           }
           else if (username==participantusername && passwaord==participantpassword)
           {
               //if same participant can show result the participant
           }
           else
           {
               //Wrong Enter!Try again!
               //return main page
           }
           */
        }

        public void answerQuestion()
        {
            throw new System.NotImplementedException();
        }

        public void leaveTest()
        {
            throw new System.NotImplementedException();
           
        }

        public void useJoker()
        {
            throw new System.NotImplementedException();
        }
    }
}