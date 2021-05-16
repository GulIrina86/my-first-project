using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApplitation
{
    class Employee
    {
        public int SkillLevel { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int _workExperience;

       
        public Employee(int skill, string name, string sname, int work)
        {
          SkillLevel = skill;
          Name = name;
          Surname = sname;
           _workExperience = work;
        } 
        public int getBonusPercent()
        {
            int pr = 0;
            if (SkillLevel < 1)
                pr = 0;
             if (SkillLevel < 5 && SkillLevel > 0)
                pr = 5;
            else if (SkillLevel >= 5 && _workExperience < 3)
                pr = 10;
            else if (SkillLevel >= 5 && _workExperience >= 3 && _workExperience <= 4)
                pr = 15;
            else if (SkillLevel >= 5 && _workExperience == 5)
                pr = 20;
            return pr;
        }//getBonus
    }
    }//class Employ

    