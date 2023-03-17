using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeccaUI_THDxIOT.Shared.Models
{
	public class Trigger
	{
		public Trigger() {
			TriggerID = 0;
		}

		[Required, Key]
		public long TriggerID { set; get; }

		[Required]
		public string TriggerName { set; get; }

		public string TriggerType { set; get; }

		public string AudioTextTrigger { set; get; }

		public string SenseTrigger { set; get; }

		public List<TriggersReactions> TriggersReactions { set; get; }

	}
}