using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeccaUI_THDxIOT.Shared.Models
{
	public class MotorState
	{

		public MotorState(Motor pMotor)
		{
			Motor = pMotor;
		}

		public MotorState(Motor pMotor, int rotationAngel)
		{
			Motor = pMotor;
			RotationAngel = rotationAngel;
		}


		public MotorState()
		{
		}

		[Required, Key]

		public long MotorStateID { set; get; }

		public Motor Motor { set; get; }

		[ForeignKey("reactionStep"), Column(Order =2)]
		public long ReactionStepID { set; get; }
	
		public ReactionStep reactionStep { set; get; }

		public int RotationAngel { set; get; }

		public byte RotationOrder { set; get; }
	}
}
public enum Motor
{
	BackShoulder_LA,
	SideShoulder_LA,
	ForeArm_LA,
	BackShoulder_RA,
	SideShoulder_RA,
	ForeArm_RA,
};