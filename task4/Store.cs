using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Store
    {
        private Article[] articles;
        
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < 5)
                    return articles[index].ToString();
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
        public string this[string index]
        {
            get
            {
                string result = "";
                for (int i = 0; i < 5; i++)
                    if (articles[i].Name == index)
                        result += articles[i].ToString() + "\n";
                if (result == "")
                    return "данного товара нет в каталоге.";
                else
                    return result;
            }
        }
        public Store()
        {
            articles = new Article[5] {new Article("apple", "novus", 26.30), new Article("apple", "ashan", 22.15), 
                new Article("apple", "ATB", 20.80), new Article("cheese", "novus", 230), new Article("cheese", "ashan", 236.10)};
        }
    }
}
