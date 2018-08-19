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
        /// <summary>
        /// Search List Object
        /// </summary>
        public SearchList()
        {
            searchList = new List<SearchItem>();
        }
        /// <summary>
        /// Get search Item
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public SearchItem this[int index]=>searchList[index];

        public void addItem(String name, String price, String description, String image)=>
            searchList.Add(new SearchItem(name, description, price, image));

        /// <summary>
        /// Get Search List
        /// </summary>
        /// <returns>Search List</returns>
        public List<SearchItem> returnList()
        {
            return searchList;
        }
        /// <summary>
        /// Get Count
        /// </summary>
        /// <returns></returns>
        public int getCount()
        {
            return searchList.Count();
        }
        /// <summary>
        /// Clear Search List
        /// </summary>
        public void clear()
        {
            searchList.Clear();
        }
        

    }
}
