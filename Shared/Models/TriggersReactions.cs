
namespace MeccaUI_THDxIOT.Shared.Models
{
    public class TriggersReactions
    {
        public TriggersReactions(long triggerId, long reactionID)
        {
            TriggerId = triggerId;
            ReactionID = reactionID;
        }

        public TriggersReactions()
        {
        }

        public long TriggerId { get; set; }
            public Trigger Trigger { get; set; }
            public long ReactionID { get; set; }
            public Reaction Reaction { get; set; }

       
    }
}
