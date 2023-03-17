IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE TABLE [ChargeRecord] (
        [ChargeRecord_ID] bigint NOT NULL IDENTITY,
        [ChargeLevel] int NOT NULL,
        [IsCharging] bit NOT NULL,
        [DateTimeOfRecord] datetime2 NOT NULL,
        CONSTRAINT [PK_ChargeRecord] PRIMARY KEY ([ChargeRecord_ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE TABLE [Reactions] (
        [ReactionID] bigint NOT NULL IDENTITY,
        [ReactionName] nvarchar(max) NULL,
        [EmotionalCondition] nvarchar(max) NULL,
        [IsDefault] bit NOT NULL,
        CONSTRAINT [PK_Reactions] PRIMARY KEY ([ReactionID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE TABLE [Triggers] (
        [TriggerID] bigint NOT NULL IDENTITY,
        [TriggerName] nvarchar(max) NOT NULL,
        [TriggerType] nvarchar(max) NULL,
        [AudioTextTrigger] nvarchar(max) NULL,
        [SenseTrigger] nvarchar(max) NULL,
        CONSTRAINT [PK_Triggers] PRIMARY KEY ([TriggerID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE TABLE [VolumeRecord] (
        [VolumeRecod_ID] bigint NOT NULL IDENTITY,
        [VolumeLevel] int NOT NULL,
        [ateTimeOfRecord] datetime2 NOT NULL,
        CONSTRAINT [PK_VolumeRecord] PRIMARY KEY ([VolumeRecod_ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE TABLE [ReactionSteps] (
        [ReactionStepID] bigint NOT NULL IDENTITY,
        [ReactionID] bigint NOT NULL,
        [TextToSpeak] nvarchar(max) NULL,
        [StepOrder] tinyint NOT NULL,
        CONSTRAINT [PK_ReactionSteps] PRIMARY KEY ([ReactionStepID]),
        CONSTRAINT [FK_ReactionSteps_Reactions_ReactionID] FOREIGN KEY ([ReactionID]) REFERENCES [Reactions] ([ReactionID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE TABLE [triggersReactions] (
        [TriggerId] bigint NOT NULL,
        [ReactionID] bigint NOT NULL,
        CONSTRAINT [PK_triggersReactions] PRIMARY KEY ([TriggerId], [ReactionID]),
        CONSTRAINT [FK_triggersReactions_Reactions_ReactionID] FOREIGN KEY ([ReactionID]) REFERENCES [Reactions] ([ReactionID]) ON DELETE CASCADE,
        CONSTRAINT [FK_triggersReactions_Triggers_TriggerId] FOREIGN KEY ([TriggerId]) REFERENCES [Triggers] ([TriggerID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE TABLE [MotorStates] (
        [MotorStateID] bigint NOT NULL IDENTITY,
        [Motor] int NOT NULL,
        [ReactionStepID] bigint NOT NULL,
        [RotationAngel] int NOT NULL,
        [RotationOrder] tinyint NOT NULL,
        CONSTRAINT [PK_MotorStates] PRIMARY KEY ([MotorStateID]),
        CONSTRAINT [FK_MotorStates_ReactionSteps_ReactionStepID] FOREIGN KEY ([ReactionStepID]) REFERENCES [ReactionSteps] ([ReactionStepID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ChargeRecord_ID', N'ChargeLevel', N'DateTimeOfRecord', N'IsCharging') AND [object_id] = OBJECT_ID(N'[ChargeRecord]'))
        SET IDENTITY_INSERT [ChargeRecord] ON;
    INSERT INTO [ChargeRecord] ([ChargeRecord_ID], [ChargeLevel], [DateTimeOfRecord], [IsCharging])
    VALUES (CAST(1 AS bigint), 50, '2020-06-16T06:15:49.2695127+02:00', CAST(1 AS bit)),
    (CAST(2 AS bigint), 20, '2020-06-16T08:15:49.2695884+02:00', CAST(0 AS bit)),
    (CAST(3 AS bigint), 75, '2020-06-16T09:15:49.2695931+02:00', CAST(1 AS bit));
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ChargeRecord_ID', N'ChargeLevel', N'DateTimeOfRecord', N'IsCharging') AND [object_id] = OBJECT_ID(N'[ChargeRecord]'))
        SET IDENTITY_INSERT [ChargeRecord] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ReactionID', N'EmotionalCondition', N'IsDefault', N'ReactionName') AND [object_id] = OBJECT_ID(N'[Reactions]'))
        SET IDENTITY_INSERT [Reactions] ON;
    INSERT INTO [Reactions] ([ReactionID], [EmotionalCondition], [IsDefault], [ReactionName])
    VALUES (CAST(1 AS bigint), NULL, CAST(1 AS bit), N'I Love You Too'),
    (CAST(2 AS bigint), N'Happy', CAST(0 AS bit), N'1 Years Old'),
    (CAST(3 AS bigint), N'sad', CAST(0 AS bit), N'Of Course');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ReactionID', N'EmotionalCondition', N'IsDefault', N'ReactionName') AND [object_id] = OBJECT_ID(N'[Reactions]'))
        SET IDENTITY_INSERT [Reactions] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TriggerID', N'AudioTextTrigger', N'SenseTrigger', N'TriggerName', N'TriggerType') AND [object_id] = OBJECT_ID(N'[Triggers]'))
        SET IDENTITY_INSERT [Triggers] ON;
    INSERT INTO [Triggers] ([TriggerID], [AudioTextTrigger], [SenseTrigger], [TriggerName], [TriggerType])
    VALUES (CAST(1 AS bigint), N'I Love You Meccano', NULL, N'I Love You', N'Audio'),
    (CAST(2 AS bigint), N'How is your Age', N'Swapping', N'Age Question', N'Mixed'),
    (CAST(3 AS bigint), N'do you like me', NULL, N'do you like me', N'Audio');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TriggerID', N'AudioTextTrigger', N'SenseTrigger', N'TriggerName', N'TriggerType') AND [object_id] = OBJECT_ID(N'[Triggers]'))
        SET IDENTITY_INSERT [Triggers] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'VolumeRecod_ID', N'VolumeLevel', N'ateTimeOfRecord') AND [object_id] = OBJECT_ID(N'[VolumeRecord]'))
        SET IDENTITY_INSERT [VolumeRecord] ON;
    INSERT INTO [VolumeRecord] ([VolumeRecod_ID], [VolumeLevel], [ateTimeOfRecord])
    VALUES (CAST(1 AS bigint), 50, '2020-06-16T06:15:49.2633390+02:00'),
    (CAST(2 AS bigint), 20, '2020-06-16T08:15:49.2675024+02:00'),
    (CAST(3 AS bigint), 75, '2020-06-16T09:15:49.2675115+02:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'VolumeRecod_ID', N'VolumeLevel', N'ateTimeOfRecord') AND [object_id] = OBJECT_ID(N'[VolumeRecord]'))
        SET IDENTITY_INSERT [VolumeRecord] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ReactionStepID', N'ReactionID', N'StepOrder', N'TextToSpeak') AND [object_id] = OBJECT_ID(N'[ReactionSteps]'))
        SET IDENTITY_INSERT [ReactionSteps] ON;
    INSERT INTO [ReactionSteps] ([ReactionStepID], [ReactionID], [StepOrder], [TextToSpeak])
    VALUES (CAST(1 AS bigint), CAST(1 AS bigint), CAST(1 AS tinyint), N'I Love You Too');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ReactionStepID', N'ReactionID', N'StepOrder', N'TextToSpeak') AND [object_id] = OBJECT_ID(N'[ReactionSteps]'))
        SET IDENTITY_INSERT [ReactionSteps] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ReactionStepID', N'ReactionID', N'StepOrder', N'TextToSpeak') AND [object_id] = OBJECT_ID(N'[ReactionSteps]'))
        SET IDENTITY_INSERT [ReactionSteps] ON;
    INSERT INTO [ReactionSteps] ([ReactionStepID], [ReactionID], [StepOrder], [TextToSpeak])
    VALUES (CAST(2 AS bigint), CAST(1 AS bigint), CAST(2 AS tinyint), N'1 Years Old');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ReactionStepID', N'ReactionID', N'StepOrder', N'TextToSpeak') AND [object_id] = OBJECT_ID(N'[ReactionSteps]'))
        SET IDENTITY_INSERT [ReactionSteps] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ReactionStepID', N'ReactionID', N'StepOrder', N'TextToSpeak') AND [object_id] = OBJECT_ID(N'[ReactionSteps]'))
        SET IDENTITY_INSERT [ReactionSteps] ON;
    INSERT INTO [ReactionSteps] ([ReactionStepID], [ReactionID], [StepOrder], [TextToSpeak])
    VALUES (CAST(3 AS bigint), CAST(1 AS bigint), CAST(3 AS tinyint), N'Of Course');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ReactionStepID', N'ReactionID', N'StepOrder', N'TextToSpeak') AND [object_id] = OBJECT_ID(N'[ReactionSteps]'))
        SET IDENTITY_INSERT [ReactionSteps] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MotorStateID', N'Motor', N'ReactionStepID', N'RotationAngel', N'RotationOrder') AND [object_id] = OBJECT_ID(N'[MotorStates]'))
        SET IDENTITY_INSERT [MotorStates] ON;
    INSERT INTO [MotorStates] ([MotorStateID], [Motor], [ReactionStepID], [RotationAngel], [RotationOrder])
    VALUES (CAST(1 AS bigint), 0, CAST(1 AS bigint), 90, CAST(0 AS tinyint)),
    (CAST(2 AS bigint), 1, CAST(1 AS bigint), 90, CAST(0 AS tinyint)),
    (CAST(3 AS bigint), 2, CAST(1 AS bigint), 90, CAST(0 AS tinyint)),
    (CAST(4 AS bigint), 3, CAST(1 AS bigint), 90, CAST(0 AS tinyint)),
    (CAST(5 AS bigint), 4, CAST(1 AS bigint), 90, CAST(0 AS tinyint)),
    (CAST(6 AS bigint), 5, CAST(1 AS bigint), 90, CAST(0 AS tinyint));
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MotorStateID', N'Motor', N'ReactionStepID', N'RotationAngel', N'RotationOrder') AND [object_id] = OBJECT_ID(N'[MotorStates]'))
        SET IDENTITY_INSERT [MotorStates] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE INDEX [IX_MotorStates_ReactionStepID] ON [MotorStates] ([ReactionStepID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE INDEX [IX_ReactionSteps_ReactionID] ON [ReactionSteps] ([ReactionID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    CREATE INDEX [IX_triggersReactions_ReactionID] ON [triggersReactions] ([ReactionID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616041549_finalx')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200616041549_finalx', N'3.1.5');
END;

GO

