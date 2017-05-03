namespace KKEcpert.Service.Item
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using KKExpert.Model.Binding_Models;
    using KKExpert.Model.Entity_Models;

    public class ItemService : Service
    {
        public IEnumerable<Item> GetAllItems()
        {
            return this.Context.Items.ToList();

        }

        public Item GetItemById(int id)
        {
            return this.Context.Items.Find(id);
        }

        public void CreateItem(ItemBm item)
        {
            Item entityItem = Mapper.Map<ItemBm, Item>(item);
            this.Context.Items.Add(entityItem);

            this.Context.SaveChanges();


        }
    }
}
