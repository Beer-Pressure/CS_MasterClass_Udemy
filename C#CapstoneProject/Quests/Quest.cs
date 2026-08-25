using CapstoneProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject.Quests
{
    internal class Quest
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public QuestStatus Status { get; set; }

        public void Start()
        {
        }

        public void Complete()
        {
        }
    }
}
