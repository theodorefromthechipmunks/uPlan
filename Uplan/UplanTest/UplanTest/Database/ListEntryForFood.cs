﻿using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;

namespace UplanTest
{
    static class ListEntryForFood
    {
        public static void Initiate()
        {
            var col = Database.db.GetCollection<ListEntry>("ListEntries");

            col.Insert(new ListEntry { Type = "PROTEIN", Code = "LUPPIN", Description = "Luppin" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "SPLIT_PEAS", Description = "Split Peas" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "PEAS", Description = "Peas" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "TEMPH", Description = "Temph" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "VEGGIE_MEAT", Description = "Veggie meat" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "SOY_SEAD", Description = "Soy Sead" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "NUTS", Description = "Nuts" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "LENTILS", Description = "Lentils" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "GAMBAS", Description = "Gambas" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "SHRIMP", Description = "Shrimp" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "OYSTERS", Description = "Oysters" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "MUSSEL", Description = "Mussel" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "CRAB", Description = "Crab" }); 
            col.Insert(new ListEntry { Type = "PROTEIN", Code = " SEE_BASS", Description = "See bass" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "OTHER_F", Description = "Other" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "BEANS", Description = "Beans" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "TOFU", Description = "Tofu" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "OTHER_M", Description = "Other meat" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "BEEF", Description = "Beef" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "SALMON", Description = "Salmon" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "TUNA", Description = "Tuna" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "COB", Description = "Cob" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "SHEEP", Description = "Sheep" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "LAMB", Description = "Lamb" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "BAT", Description = "Bat" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "PROK", Description = "Pork" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "EGGS", Description = "Eggs" });
            col.Insert(new ListEntry { Type = "PROTEIN", Code = "CHICKEN", Description = "Chicken" });

            col.Insert(new ListEntry { Type = "CARB", Code = "BROWN_RICE", Description = "Brown rice" });
            col.Insert(new ListEntry { Type = "CARB", Code = "WHITE_RICE", Description = "White rice" });
            col.Insert(new ListEntry { Type = "CARB", Code = "WHOLE_PASTA", Description = "Whole Pasta" });
            col.Insert(new ListEntry { Type = "CARB", Code = "PASTA", Description = "Pasta" });
            col.Insert(new ListEntry { Type = "CARB", Code = "QUINOA", Description = "Quinoa" });
            col.Insert(new ListEntry { Type = "CARB", Code = "LENTILS", Description = "Lentils" });
            col.Insert(new ListEntry { Type = "CARB", Code = "POTATO", Description = "Potato" });
            col.Insert(new ListEntry { Type = "CARB", Code = "SWEET_POTATO", Description = "Sweet Potato" });
            col.Insert(new ListEntry { Type = "CARB", Code = "RED_BEANS", Description = "Red Beans" });
            col.Insert(new ListEntry { Type = "CARB", Code = "KIDEY_BEANS", Description = "Kidney Beans" });

            col.Insert(new ListEntry { Type = "VEGGIES", Code = "SPINACH", Description = "Spinach" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "BROCCOLI", Description = "Broccoli" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "AVOCADO", Description = "Avocado" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "CARROT", Description = "Carrot" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "TOMATO", Description = "Tomato" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "CORN", Description = "Corn" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "OLIVES", Description = "Olives" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "BUTTERNUT", Description= "Buternut"});   
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "SALAD", Description = "Salad" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "CAULIFLOWER", Description = "Cauliflower" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "ASPARGUS", Description = "Aspargus" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "COURGETTE", Description = "Courgette" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "CUCUMBER", Description = "Cucumber" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "GREEN_BEANS", Description = "Green Beans" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "BEETROOT", Description = "Beetroot" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "PUMKIN", Description = "Pumkin" });
            col.Insert(new ListEntry { Type = "VEGGIES", Code = "EGGPLANT", Description = "Eggplant" });
        }
    }
}