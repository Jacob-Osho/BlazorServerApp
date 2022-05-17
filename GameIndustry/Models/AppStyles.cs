using System.Collections.Generic;

namespace GameIndustry.Models
{
    public class AppStyles
    {
        public string Color { get; set; } = "green";
        public string Size { get; set; } = "65px";

        public List<string> WitcherWords { get; set; } = new List<string>()
        {
            "I'll carry on killing monsters in the ruins of this world until some monster kills me.",
            "I run into dilemmas all the time... This is not one of them. You disgust me. And deserve to die.",
            "You know f*ck all, Dandelion.",
            "You'd better pay up, or the invisible hand of the market will smack you so hard you won't sit down for a week.",
            "Lambert, Lambert, what a prick.",
            "Beware of an old man in a profession where men usually die young.",
            "This world doesn't need a hero. It needs a professional.",
            "It is easy to kill with a bow, girl.",
            "Well, we’re afeared. And what of it? Do we sit down and weep and tremble? Life must go on. And what will be, will be. What is destined can’t be avoided, in any case.",
            "Mistakes are also important to me. I don’t cross them out of my life, or memory. And I never blame others for them."
        };







        public List<TableListModel> TableStyle { get; set; } = new List<TableListModel>()
        {
            new TableListModel()
            {
                Text = "Table Dark",
                Value ="table-dark"

            },
             new TableListModel()
            {
                  Text = "Table Striped",
                Value ="table-striped"
            },
              new TableListModel()
             {
                   Text = "Table Bordered",
                Value ="table-bordered"
             },
               new TableListModel()
             {
                   Text = "Table Success",
                Value =  "table-success"

             },
                new TableListModel()
             {
                   Text = "Table Danger",
                Value ="table-danger"
             },
                 new TableListModel()
             {
                   Text = "Table Warning",
                Value = "table-warning"
             },
                  new TableListModel()
             {
                   Text = "Table Info",
                Value =  "table-info"
             },
                   new TableListModel()
             {
                   Text = "Table Light",
                Value = "table-light"
             },
                    new TableListModel()
             {
                   Text = "Table Secondary",
                Value ="table-secondary"
             },
                     new TableListModel()
             {
                   Text = "Table Primary",
                Value = "table-primary"
             },
        };

    }

}
