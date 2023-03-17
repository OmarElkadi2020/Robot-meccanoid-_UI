using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeccaUI_THDxIOT.Server.Migrations
{
    public partial class finalx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChargeRecord",
                columns: table => new
                {
                    ChargeRecord_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChargeLevel = table.Column<int>(nullable: false),
                    IsCharging = table.Column<bool>(nullable: false),
                    DateTimeOfRecord = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargeRecord", x => x.ChargeRecord_ID);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    ReactionID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReactionName = table.Column<string>(nullable: true),
                    EmotionalCondition = table.Column<string>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.ReactionID);
                });

            migrationBuilder.CreateTable(
                name: "Triggers",
                columns: table => new
                {
                    TriggerID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TriggerName = table.Column<string>(nullable: false),
                    TriggerType = table.Column<string>(nullable: true),
                    AudioTextTrigger = table.Column<string>(nullable: true),
                    SenseTrigger = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Triggers", x => x.TriggerID);
                });

            migrationBuilder.CreateTable(
                name: "VolumeRecord",
                columns: table => new
                {
                    VolumeRecod_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolumeLevel = table.Column<int>(nullable: false),
                    ateTimeOfRecord = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolumeRecord", x => x.VolumeRecod_ID);
                });

            migrationBuilder.CreateTable(
                name: "ReactionSteps",
                columns: table => new
                {
                    ReactionStepID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReactionID = table.Column<long>(nullable: false),
                    TextToSpeak = table.Column<string>(nullable: true),
                    StepOrder = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactionSteps", x => x.ReactionStepID);
                    table.ForeignKey(
                        name: "FK_ReactionSteps_Reactions_ReactionID",
                        column: x => x.ReactionID,
                        principalTable: "Reactions",
                        principalColumn: "ReactionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "triggersReactions",
                columns: table => new
                {
                    TriggerId = table.Column<long>(nullable: false),
                    ReactionID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_triggersReactions", x => new { x.TriggerId, x.ReactionID });
                    table.ForeignKey(
                        name: "FK_triggersReactions_Reactions_ReactionID",
                        column: x => x.ReactionID,
                        principalTable: "Reactions",
                        principalColumn: "ReactionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_triggersReactions_Triggers_TriggerId",
                        column: x => x.TriggerId,
                        principalTable: "Triggers",
                        principalColumn: "TriggerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorStates",
                columns: table => new
                {
                    MotorStateID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motor = table.Column<int>(nullable: false),
                    ReactionStepID = table.Column<long>(nullable: false),
                    RotationAngel = table.Column<int>(nullable: false),
                    RotationOrder = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorStates", x => x.MotorStateID);
                    table.ForeignKey(
                        name: "FK_MotorStates_ReactionSteps_ReactionStepID",
                        column: x => x.ReactionStepID,
                        principalTable: "ReactionSteps",
                        principalColumn: "ReactionStepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChargeRecord",
                columns: new[] { "ChargeRecord_ID", "ChargeLevel", "DateTimeOfRecord", "IsCharging" },
                values: new object[,]
                {
                    { 1L, 50, new DateTime(2020, 6, 16, 6, 15, 49, 269, DateTimeKind.Local).AddTicks(5127), true },
                    { 2L, 20, new DateTime(2020, 6, 16, 8, 15, 49, 269, DateTimeKind.Local).AddTicks(5884), false },
                    { 3L, 75, new DateTime(2020, 6, 16, 9, 15, 49, 269, DateTimeKind.Local).AddTicks(5931), true }
                });

            migrationBuilder.InsertData(
                table: "Reactions",
                columns: new[] { "ReactionID", "EmotionalCondition", "IsDefault", "ReactionName" },
                values: new object[,]
                {
                    { 1L, null, true, "I Love You Too" },
                    { 2L, "Happy", false, "1 Years Old" },
                    { 3L, "sad", false, "Of Course" }
                });

            migrationBuilder.InsertData(
                table: "Triggers",
                columns: new[] { "TriggerID", "AudioTextTrigger", "SenseTrigger", "TriggerName", "TriggerType" },
                values: new object[,]
                {
                    { 1L, "I Love You Meccano", null, "I Love You", "Audio" },
                    { 2L, "How is your Age", "Swapping", "Age Question", "Mixed" },
                    { 3L, "do you like me", null, "do you like me", "Audio" }
                });

            migrationBuilder.InsertData(
                table: "VolumeRecord",
                columns: new[] { "VolumeRecod_ID", "VolumeLevel", "ateTimeOfRecord" },
                values: new object[,]
                {
                    { 1L, 50, new DateTime(2020, 6, 16, 6, 15, 49, 263, DateTimeKind.Local).AddTicks(3390) },
                    { 2L, 20, new DateTime(2020, 6, 16, 8, 15, 49, 267, DateTimeKind.Local).AddTicks(5024) },
                    { 3L, 75, new DateTime(2020, 6, 16, 9, 15, 49, 267, DateTimeKind.Local).AddTicks(5115) }
                });

            migrationBuilder.InsertData(
                table: "ReactionSteps",
                columns: new[] { "ReactionStepID", "ReactionID", "StepOrder", "TextToSpeak" },
                values: new object[] { 1L, 1L, (byte)1, "I Love You Too" });

            migrationBuilder.InsertData(
                table: "ReactionSteps",
                columns: new[] { "ReactionStepID", "ReactionID", "StepOrder", "TextToSpeak" },
                values: new object[] { 2L, 1L, (byte)2, "1 Years Old" });

            migrationBuilder.InsertData(
                table: "ReactionSteps",
                columns: new[] { "ReactionStepID", "ReactionID", "StepOrder", "TextToSpeak" },
                values: new object[] { 3L, 1L, (byte)3, "Of Course" });

            migrationBuilder.InsertData(
                table: "MotorStates",
                columns: new[] { "MotorStateID", "Motor", "ReactionStepID", "RotationAngel", "RotationOrder" },
                values: new object[,]
                {
                    { 1L, 0, 1L, 90, (byte)0 },
                    { 2L, 1, 1L, 90, (byte)0 },
                    { 3L, 2, 1L, 90, (byte)0 },
                    { 4L, 3, 1L, 90, (byte)0 },
                    { 5L, 4, 1L, 90, (byte)0 },
                    { 6L, 5, 1L, 90, (byte)0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MotorStates_ReactionStepID",
                table: "MotorStates",
                column: "ReactionStepID");

            migrationBuilder.CreateIndex(
                name: "IX_ReactionSteps_ReactionID",
                table: "ReactionSteps",
                column: "ReactionID");

            migrationBuilder.CreateIndex(
                name: "IX_triggersReactions_ReactionID",
                table: "triggersReactions",
                column: "ReactionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChargeRecord");

            migrationBuilder.DropTable(
                name: "MotorStates");

            migrationBuilder.DropTable(
                name: "triggersReactions");

            migrationBuilder.DropTable(
                name: "VolumeRecord");

            migrationBuilder.DropTable(
                name: "ReactionSteps");

            migrationBuilder.DropTable(
                name: "Triggers");

            migrationBuilder.DropTable(
                name: "Reactions");
        }
    }
}
