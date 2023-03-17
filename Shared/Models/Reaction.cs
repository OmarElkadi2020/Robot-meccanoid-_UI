using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using System.Text;

namespace MeccaUI_THDxIOT.Shared.Models
{
    public class Reaction
    {
        public Reaction()
        {
            TriggersReactions = new LinkedList<TriggersReactions>();
            ReactionSteps = new LinkedList<ReactionStep>();
        }

        [Key, Required]
        public long ReactionID { set; get; }

        public String ReactionName { set; get; }

        public string EmotionalCondition { set; get; }

        public bool IsDefault { set; get; }

        public LinkedList<TriggersReactions> TriggersReactions { set; get; }

        public LinkedList <ReactionStep> ReactionSteps { set; get; }


    }
}
