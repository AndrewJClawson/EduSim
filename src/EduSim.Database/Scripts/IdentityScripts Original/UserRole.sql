CREATE TABLE [dbo].[UserRole]
(
    [UserID] INT NOT NULL,
    [RoleID] INT NOT NULL,

    CONSTRAINT [PK_UserRole_UserID_RoleID] PRIMARY KEY CLUSTERED ([UserID] ASC, [RoleID] ASC),
    CONSTRAINT [FK_UserRole_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([UserID]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserRole_Role] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Role] ([RoleID]) ON DELETE CASCADE
);

GO
CREATE NONCLUSTERED INDEX [IX_UserUserRole_UserID]
    ON [dbo].[UserRole] ([UserID] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_UserUserRole_RoleID]
    ON [dbo].[UserRole] ([RoleID] ASC);