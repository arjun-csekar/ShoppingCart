using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SearchList
    {
        List<SearchItem> searchList;

        public SearchList()
        {
            searchList = new List<SearchItem>();
        }

        public void addItem(String name, String price, String description, String image)=>
            searchList.Add(new SearchItem(name, description, price, image));

        public List<SearchItem> returnList()
        {
            return searchList;
        }

        public void clear()
        {
            searchList.Clear();
        }
        

    }
}
