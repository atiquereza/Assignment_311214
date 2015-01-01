using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ResultCalculatorApp
{
    class Result
    {


        private double physicsNumber;
        private double chemistryNumber;
        private double mathNumber;
        

        private double PhysicsNumber {
            set
            {
                if (0 <= value && value < 101)
                {
                    physicsNumber = value;

                }
                else throw new Exception("Physics Number cannot be Greater than 100");
            }
            get { return physicsNumber; } 
        }

        private double ChemistryNumber
        {
            get { return chemistryNumber; }
            set
            {
                if (0 <= value && value < 101)
                {
                    chemistryNumber = value;

                }
                else throw new Exception("Chemistry Number cannot be Greater than 100");
            }
        }

        private double MathNumber
        {
            get { return mathNumber; }
            set
            {
                if (0 <= value && value < 101)
                {
                    mathNumber = value;

                }
                else throw new Exception("Math Number cannot be Greater than 100");
            }
        }


       

        public double GetAverageResult(double physicsNumber, double chemistryNumber, double mathNumber)
        {
            PhysicsNumber = physicsNumber;

            
            //PhysicsNumber.
            ChemistryNumber = chemistryNumber;
            MathNumber = mathNumber;
            
            return (ChemistryNumber + PhysicsNumber + MathNumber)/3;
        }



        public string GetGrade(double average)
        {
            
            if (average >= 80)
            {
                return "A+";
            }
            else if (average >= 70)
            {
                return "B+";
            }
            else if (average >= 60)
            {
                return "C+";
            }
            else if (average >= 50)
            {
                return "D+";
            }
            else return "F";
        }

        
    }
}
