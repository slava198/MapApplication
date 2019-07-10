using System;
using System.Collections.Generic;
using System.Linq;


namespace MapApplication.Entities
{

    public class Bank
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Departmen> departmens { get; set; }
        public Course currentCourse { get; set; }


        public override string ToString()
        {
            return String.Format($"{name}");
        }


        public void AddDepartment(Departmen departmen)
        {
            departmens.Add(departmen);
        }


        public void SetCourse(CourseRepository courses)
        {
            currentCourse = courses.GetCourses().Where(cс => cс.BankID == this.id).FirstOrDefault();
        }


        public void SetID()
        {
            switch (name)
            {
                case "БеларусБанк":
                    id = 18;
                    break;
                case "БелАгроПромБанк":
                    id = 4;
                    break;
                case "ТехноБанк":
                    id = 20;
                    break;
                case "БПС-Сбербанк":
                    id = 9;
                    break;
                case "Паритетбанк":
                    id = 16;
                    break;
                case "ПриорБанк":
                    id = 17;
                    break;
                case "МТБанк":
                    id = 15;
                    break;
                case "БелСвиссБанк":
                    id = 11;
                    break;
                case "СтатусБанк":
                    id = 14;
                    break;
                case "Альфа-Банк":
                    id = 2;
                    break;
                case "РРБ-Банк":
                    id = 28;
                    break;
                case "Абсолютбанк":
                    id = 1;
                    break;
                case "Цептер Банк":
                    id = 22;
                    break;
                case "ТК Банк":
                    id = 30;
                    break;
                case "Банк Решение":
                    id = 24;
                    break;
            }
        }


        public void SetName()
        {
            switch (id)
            {
                case 18:
                    name = "БеларусБанк";
                    break;
                case 4:
                    name = "БелАгроПромБанк";
                    break;
                case 20:
                    name = "ТехноБанк";
                    break;
                case 9:
                    name = "БПС-Сбербанк";
                    break;
                case 16:
                    name = "Паритетбанк";
                    break;
                case 17:
                    name = "ПриорБанк";
                    break;
                case 15:
                    name = "МТБанк";
                    break;
                case 11:
                    name = "БелСвиссБанк";
                    break;
                case 14:
                    name = "СтатусБанк";
                    break;
                case 2:
                    name = "Альфа-Банк";
                    break;
                case 28:
                    name = "РРБ-Банк";
                    break;
                case 1:
                    name = "Абсолютбанк";
                    break;
                case 22:
                    name = "Цептер Банк";
                    break;
                case 30:
                    name = "ТК Банк";
                    break;
                case 24:
                    name = "Банк Решение";
                    break;
            }
        }
    }
}

