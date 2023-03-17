using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeccaUI_THDxIOT.Shared.Models
{
	public class ReactionStep
	{
		public ReactionStep()
		{
			Movement= new LinkedList<MotorState>();
		}

		public ReactionStep(LinkedList<MotorState> movement, string textToSpeak, byte stepOrder)
		{
			Movement = new LinkedList<MotorState>(movement);
			TextToSpeak = textToSpeak;
			StepOrder = stepOrder;
		}

		[Required, Key]
		public long ReactionStepID { set; get; }


		[ForeignKey("reation")]
		public long ReactionID { set; get; }

		public Reaction reaction { set; get; }


		public LinkedList<MotorState> Movement { set; get; }

		public string TextToSpeak { set; get; }

		public byte StepOrder { set; get; }

	}
}