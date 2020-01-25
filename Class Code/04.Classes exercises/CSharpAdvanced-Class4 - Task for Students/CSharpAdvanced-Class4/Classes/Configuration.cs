﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using CSharpAdvanced_Class4.Interfaces;
using static CSharpAdvanced_Class4.Enums.Enums;

namespace CSharpAdvanced_Class4
{     
    public abstract class Item 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }  
    }

    public class Part : Item, IPrice
    { 
        public double GetPrice()
        {
            return Price;
        } 
    }

    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>(); 

        public Module() { }
        public Module(string name)
        {
            Name = name;
        }

        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part); 
        } 
        
        public double GetPrice()
        {
            double price = 0.0;
            // TODO: Implement the GetPrice() method for the Modules
            foreach (var item in _parts)
            {
                price += item.Price * item.Quantity;
            }

            return price; // remove this after implementation
        }

        public void SetDiscount(double discount)
        {

            if (discount <= 100 && discount > 0)
            {
                Discount = discount / 100;
            }
            // TODO: Implement the SetDiscount() method for the Modules
            /*
             * The percentage is a number in the range [0,100]. 5% == 0.05, 10% == 0.1
             * The method should set the Discount property to values between [0.00, 1.00]
             */
        }

        public double GetPriceWithDiscount()
        { 
            return GetPrice() * (1 - Discount);
        }
    }

    public class Configuration : Item, IPrice, IDiscont
    {
        public Colors BoxColor { get; set; }
        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();
        public List<Part> Parts { get; set; }
        public List<Module> Modules { get; set; } 

        public Configuration() { }
        public Configuration(Colors boxColor)
        { 
            BoxColor = boxColor;
        }

        public void AddPartToProduct(Part part, int quantity = 1)
        {
            // TODO: Implement the AddPartToProduct() method for the Configuration 
        
                part.Quantity = quantity;
                _parts.Add(part);
            
        }

        public void AddModuleToProduct(Module module, int quantity = 1)
        {
            // TODO: Implement the AddModuleToProduct() method for the Configurations 

            module.Quantity = quantity;
            _modules.Add(module);

        }
         
        public double GetPrice()
        {
            // TODO: Implement the GetPrice() method for the Configurations
            /* 
             * Consider the _parts and _modules lists. Two foreach loops are needed.
             */
                   
            double price = 0.0;
            
            foreach (var item in _parts)
            {
                price += item.Price * item.Quantity;
            }

            foreach (var item in _modules)
            {
                price += item.Price * item.GetPrice();
            }

            return price; // remove this after implementation
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }

        public void SetDiscount(double discount)
        {
            // TODO: Implement the SetDiscount() method for the Configurations
            /*
             * The percentage is a number in the range [0,100]. 5% == 0.05, 10% == 0.1
             * The method should set the Discount property to values between [0.00, 1.00]
             * Implementation can be the same as in Module class.
             */
            if (discount <= 100 && discount > 0)
            {
                Discount = discount / 100;
            }
           
        }
    }
}
