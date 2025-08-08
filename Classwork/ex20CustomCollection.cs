using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace SampleConApp
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }

    class ItemColletion
    {
        private List<Item> items = new List<Item>();
        public void AddItem(Item item) => items.Add(item);

        public Item getItem(int itemId) => items.Find(it => it.Id == itemId);

        public void deleteItem(int itemId)
        {
            var item = getItem(itemId);
            if(item != null)
            {
                items.Remove(item);
            }
            else
            {
                Console.WriteLine($"{item } not found to delete");
            }
        }
        public List<Item> getallItems() => items;

        public void updateItem(Item itm)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == itm.Id)
                {
                    items[i] = itm;
                    return;
                }
            }
            
        }
        public int count => items.Count;
    }

    internal class ex20CustomCollection
    {
        static void Main(string[] args)
        {
            ItemColletion repo = new ItemColletion();
            do
            {
                Console.WriteLine("Enter the following options to perform the task:");
                Console.WriteLine("1. Add item\n 2. Update Item\n 3. Getall items\n 4. Get total count\n 5. get a item info\n");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1: additem(); break;
                    case 2: updateitem(); break;
                    case 3: getallitem(); break;
                    case 4: gettotalcount(); break;
                    case 5: getaitem(); break;
                }
            }while(true);
        }

        private static void getaitem()
        {
            Console.WriteLine("enter the item id , item name and item cost");
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            double cost = Convert.ToDouble(Console.ReadLine());
            Item item = new Item();
            item.Id = id;
            item.Name = name;
            item.Cost = cost;
            //Additem(item);
        }

        private static void gettotalcount()
        {
            throw new NotImplementedException();
        }

        private static void getallitem()
        {
            throw new NotImplementedException();
        }

        private static void updateitem()
        {
            throw new NotImplementedException();
        }

        private static void additem()
        {
            throw new NotImplementedException();
        }
    }
}
