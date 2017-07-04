using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPGChat.Model
{
    enum CardTag
    {
        COC,DND,AIS
    }
    class Card
    {
        public string name;
        public List<Item> items;
        public List<Skill> skills;
        public List<Skill> tempskills;
        public CardTag ct;
        public int HP;
        public int MP;
        public int SP;
        public int AP;
        public Dictionary<int, Skill> SkillDict;
        public Card()
        {
            
        }
        public Card(CardTag cardtag)
        {
            ct = cardtag;
        }
        public void SearchSkill(string s)
        {
            tempskills = new List<Skill>();
            foreach(Skill i in skills)
            {
                if (i.name.Contains(s))
                {

                }
                tempskills.Add(i);
            }
            tempskills.Sort();
            if (tempskills.Count == 0)
            {
                MessageBox.Show("未找到相关技能");
            }
        }
    }
    class Item
    {

    }
    class Skill
    {
        public string name;
        public string description;
        public int basic;
        public int addition;
        public int extra;
    }
    class Mod
    {

    }
    class COCMOD:Mod
    {

    }
    class DNDMOD:Mod
    {

    }
    class AISMOD:Mod
    {

    }
}
