using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented2Test
{
    internal class Homework
    {
        //Fields
        private int _estimatedTimeToComplete;    

        //Properties
        public string Subject { get; private set; }
        public int Difficulty { get; private set; }
        public DateTime DueDate { get; private set; }  

        //Constructor
        public Homework(string subject, int difficulty, DateTime dueDate)
        {
            Subject = subject;
            Difficulty = difficulty;
            DueDate = dueDate;
            UpdateEstimatedDif();
        }

        //Methods
        public string GetUrgency()
        {
            if(DueDate < DateTime.Today.AddDays(_estimatedTimeToComplete))
            {
                return "high";
            }
            else if(DueDate == DateTime.Today.AddDays(_estimatedTimeToComplete))
            {
                return "medium";
            }
            else
            {
                return "low";
            }
        }

        public string ChangeDifficulty(int difficulty) //this can also be done in set
        {
            if (difficulty <= 10 && difficulty > 0)
            {
                Difficulty = difficulty;
                UpdateEstimatedDif();
                return $"difficulty changed to {difficulty}";
            }

            else
            {
                return "invalid difficulty";
            }

            
        }

        private void UpdateEstimatedDif()
        {
            _estimatedTimeToComplete = Difficulty * 2;
        }



    }
}
