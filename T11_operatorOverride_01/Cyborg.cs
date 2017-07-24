using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_operatorOverride_01
{
    class Cyborg
    {
        public string cyborgName;
        List<Element> bodyParts = new List<Element>();

        public Cyborg(string _name)
        {
            cyborgName = _name;
        }

        public Cyborg(string _name, List<Element> parts) : this (_name)
        {
            bodyParts = parts;
        }

        // Добавление новых элементов к механизму
        public void AddElement(Element e)
        {
            bodyParts.Add(e);
        }

        // Выводим описание киборга с именем и каждой деталью
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine($"Киборг {cyborgName} с убийственным функциналом:");
            int id = 1;
            foreach (Element e in bodyParts)
            {
                s.AppendLine($"[{id}] механизм {e.name} с функцией {e.function}");
                id++;
            }
            return s.ToString();
        }


        // Складываем киборгов суммируя добавляем в нового каждую деталь от предыдущего
        public static Cyborg operator +(Cyborg c1, Cyborg c2)
        {
            List<Element> newParts = new List<Element>();
            newParts.AddRange(c1.bodyParts);
            newParts.AddRange(c2.bodyParts);

            Cyborg newCyborg = new Cyborg(c1.cyborgName + c2.cyborgName, newParts);
            return newCyborg;
        }

        public static Cyborg operator ++(Cyborg c1)
        {
            c1.bodyParts.Add(new Element("Пустой слот","ничего не далет, ждет"));
            return c1;
        }

        public static bool operator >(Cyborg c1, Cyborg c2)
        {
            if (c1.bodyParts.Count > c2.bodyParts.Count)
                return true;
            return false;
        }
        public static bool operator <(Cyborg c1, Cyborg c2)
        {
            if (c1.bodyParts.Count < c2.bodyParts.Count)
                return true;
            return false;
        }

        public static bool operator ==(Cyborg c1, Cyborg c2)
        {
            if (c1.bodyParts.Count == c2.bodyParts.Count)
                return true;
            return false;
        }

        public static bool operator !=(Cyborg c1, Cyborg c2)
        {
            if (c1.bodyParts.Count != c2.bodyParts.Count)
                return true;
            return false;
        }
    }
}
