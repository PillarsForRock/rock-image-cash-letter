﻿using System;

using Rock.Plugin;

namespace com.shepherdchurch.ImageCashLetter.Migrations.Version_1
{
    [MigrationNumber( 1, "1.6.4" )]
    public class AddSystemData : Migration
    {
        public override void Up()
        {
            RockMigrationHelper.UpdateEntityType( "com.shepherdchurch.ImageCashLetter.Model.ImageCashLetterFileFormat",
                SystemGuid.EntityType.IMAGE_CASH_LETTER_FILE_FORMAT,
                true, true );

            RockMigrationHelper.UpdateEntityType( "com.shepherdchurch.ImageCashLetter.FileFormatTypes.BankOfTheWest",
                SystemGuid.EntityType.BANK_OF_THE_WEST,
                false, true );

            Sql( @"CREATE TABLE [dbo].[_com_shepherdchurch_ImageCashLetter_FileFormat] (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[CreatedDateTime] [datetime] NULL,
	[ModifiedDateTime] [datetime] NULL,
	[CreatedByPersonAliasId] [int] NULL,
	[ModifiedByPersonAliasId] [int] NULL,
	[ForeignKey] [nvarchar](50) NULL,
	[ForeignGuid] [uniqueidentifier] NULL,
	[ForeignId] [int] NULL,
	[EntityTypeId] [int] NULL,
	[IsActive] [bit] NULL,
	[FileNameTemplate] [varchar](max) NULL,
	CONSTRAINT [PK_com_shepherdchurch_ImageCashLetter_FileFormat] PRIMARY KEY CLUSTERED ( [Id] ASC )
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

ALTER TABLE [dbo].[_com_shepherdchurch_ImageCashLetter_FileFormat]  WITH CHECK
ADD CONSTRAINT [FK_com_shepherdchurch_ImageCashLetter_FileFormat_CreatedByPersonAlias] FOREIGN KEY([CreatedByPersonAliasId]) REFERENCES [dbo].[PersonAlias] ([Id])
ALTER TABLE [dbo].[_com_shepherdchurch_ImageCashLetter_FileFormat] CHECK CONSTRAINT [FK_com_shepherdchurch_ImageCashLetter_FileFormat_CreatedByPersonAlias]

ALTER TABLE [dbo].[_com_shepherdchurch_ImageCashLetter_FileFormat]  WITH CHECK
ADD CONSTRAINT [FK_com_shepherdchurch_ImageCashLetter_FileFormat_EntityType] FOREIGN KEY([EntityTypeId]) REFERENCES [dbo].[EntityType] ([Id]) ON DELETE SET NULL
ALTER TABLE [dbo].[_com_shepherdchurch_ImageCashLetter_FileFormat] CHECK CONSTRAINT [FK_com_shepherdchurch_ImageCashLetter_FileFormat_EntityType]

ALTER TABLE [dbo].[_com_shepherdchurch_ImageCashLetter_FileFormat]  WITH CHECK
ADD CONSTRAINT [FK_com_shepherdchurch_ImageCashLetter_FileFormat_ModifiedByPersonAlias] FOREIGN KEY([ModifiedByPersonAliasId]) REFERENCES [dbo].[PersonAlias] ([Id])
ALTER TABLE [dbo].[_com_shepherdchurch_ImageCashLetter_FileFormat] CHECK CONSTRAINT [FK_com_shepherdchurch_ImageCashLetter_FileFormat_ModifiedByPersonAlias]
" );
        }

        public override void Down()
        {
        }
    }
}
