using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Admitere
{
    internal class Test
    {
        private List<Item> items = new List<Item>();
        private int testId;

        public List<Item> Items { get => items; set => items = value; }
        public int TestId { get => testId; set => testId = value; }

        internal void Load(string fileName)
        {
            Console.WriteLine(fileName);
            //GenerateMockData();
            //MockData.Save(this);
            Test t = MockData.Load(Properties.Resources.mockDataFile);
            testId = t.testId;
            items = t.items;
        }

        private void GenerateMockData()
        {
            Item item = new Item
            {
                ItemNo = 1,
                Question = new CellObject { Text = "Prima intrebare" }
            };
            item.Answers.Add(new Answer
            {
                Id = 1,
                Correct = true,
                Cell = new CellObject { Text = "Primul raspuns" }
            });
            item.Answers.Add(new Answer
            {
                Id = 2,
                Correct = false,
                Cell = new CellObject { Text = "A doilea raspuns" }
            });
            item.Answers.Add(new Answer
            {
                Id = 3,
                Correct = false,
                Cell = new CellObject { Text = "Al treilea raspuns" }
            });
            Items.Add(item);

        }

        internal Test Shuffle()
        {
            ShuffleItems();
            ShuffleAnswers();
            items.Sort(f);

            return this;
        }

        private void ShuffleAnswers()
        {
            foreach (var item in items)
            {
                item.Answers.Sort(g);
            }
        }

        private int g(Answer x, Answer y)
        {
            Random r = new Random();
            return 50 - r.Next(100);
        }

        private void ShuffleItems()
        {
            items.Sort(f);
        }

        private int f(Item x, Item y)
        {
            Random r = new Random();
            return 50 - r.Next(100);
        }
    }
}