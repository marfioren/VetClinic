﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model
{
    public class Product
    {
        private int id;
        private String name;
        private int quantity;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
