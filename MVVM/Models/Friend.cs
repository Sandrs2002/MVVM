﻿using System;
using SQLite;
using System.Collections.Generic;
using System.Text;
namespace MVVM.Models
{
    [Table("Friends")]
    public class Friend
	{
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

