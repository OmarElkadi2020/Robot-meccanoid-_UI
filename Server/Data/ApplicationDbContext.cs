using MeccaUI_THDxIOT.Shared;
using MeccaUI_THDxIOT.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace MeccaUI_THDxIOT.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }
        public DbSet<ChargeRecord> ChargeRecord { get; set; }
        public DbSet<VolumeRecord> VolumeRecord { get; set; }

        public DbSet<Trigger> Triggers { get; set; }

        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<TriggersReactions> triggersReactions { get; set; }


        public DbSet<ReactionStep> ReactionSteps { get; set; }

        public DbSet<MotorState> MotorStates { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TriggersReactions>()
            .HasKey(TR => new { TR.TriggerId , TR.ReactionID });

            modelBuilder.Entity<TriggersReactions>()
                .HasOne(TR => TR.Trigger)
                .WithMany(T => T.TriggersReactions)
                .HasForeignKey(TR => TR.TriggerId);

            modelBuilder.Entity<TriggersReactions>()
                .HasOne(TR => TR.Reaction)
                .WithMany(R => R.TriggersReactions)
                .HasForeignKey(TR => TR.ReactionID);


            modelBuilder.Entity<VolumeRecord>().HasData
            (
                 new VolumeRecord { VolumeRecod_ID = 1, VolumeLevel = 50, ateTimeOfRecord = DateTime.Now, }
                , new VolumeRecord { VolumeRecod_ID = 2, VolumeLevel = 20, ateTimeOfRecord = DateTime.Now.AddHours(2), }
                , new VolumeRecord { VolumeRecod_ID = 3, VolumeLevel = 75,  ateTimeOfRecord = DateTime.Now.AddHours(3), }
            );
            modelBuilder.Entity<ChargeRecord>().HasData
            (
                 new ChargeRecord { ChargeRecord_ID = 1, ChargeLevel = 50, IsCharging = true, DateTimeOfRecord = DateTime.Now, }
                , new ChargeRecord { ChargeRecord_ID = 2, ChargeLevel = 20, IsCharging = false, DateTimeOfRecord = DateTime.Now.AddHours(2), }
                , new ChargeRecord { ChargeRecord_ID = 3, ChargeLevel = 75, IsCharging = true, DateTimeOfRecord = DateTime.Now.AddHours(3), }
            );

            modelBuilder.Entity<Trigger>().HasData
           (
                new Trigger { TriggerID = 1, TriggerName = "I Love You", TriggerType = "Audio", AudioTextTrigger = "I Love You Meccano", SenseTrigger = null }
               , new Trigger { TriggerID = 2, TriggerName = "Age Question", TriggerType = "Mixed", AudioTextTrigger = "How is your Age", SenseTrigger = "Swapping" }
               , new Trigger { TriggerID = 3, TriggerName = "do you like me", TriggerType = "Audio", AudioTextTrigger = "do you like me", SenseTrigger = null }

           );

            modelBuilder.Entity<Reaction>().HasData
            (
                 new Reaction { ReactionID = 1, ReactionName = "I Love You Too",IsDefault=true }
                , new Reaction { ReactionID = 2,ReactionName = "1 Years Old" , EmotionalCondition = "Happy" }
                , new Reaction { ReactionID = 3, ReactionName = "Of Course", EmotionalCondition = "sad" }

            );

            modelBuilder.Entity<ReactionStep>().HasData
            (
                   new ReactionStep { ReactionStepID = 1, ReactionID = 1, TextToSpeak = "I Love You Too",StepOrder=1 }
                  , new ReactionStep { ReactionStepID = 2, ReactionID = 1, TextToSpeak = "1 Years Old", StepOrder = 2 }
                  , new ReactionStep { ReactionStepID = 3, ReactionID = 1, TextToSpeak = "Of Course", StepOrder = 3}
            );

            modelBuilder.Entity<MotorState>().HasData
            (
                 new MotorState  { MotorStateID = 1,  ReactionStepID=  1, Motor = Motor.BackShoulder_LA, RotationAngel = 90,   }
                , new MotorState { MotorStateID = 2, ReactionStepID = 1, Motor = Motor.SideShoulder_LA, RotationAngel = 90, }
                , new MotorState { MotorStateID = 3, ReactionStepID = 1, Motor = Motor.ForeArm_LA, RotationAngel = 90 }
                 ,new MotorState { MotorStateID = 4, ReactionStepID = 1, Motor = Motor.BackShoulder_RA, RotationAngel = 90}
                , new MotorState { MotorStateID = 5, ReactionStepID = 1, Motor = Motor.SideShoulder_RA, RotationAngel = 90 }
                , new MotorState { MotorStateID = 6, ReactionStepID = 1, Motor = Motor.ForeArm_RA, RotationAngel = 90 }

            );
        }
    }
}