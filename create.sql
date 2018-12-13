/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V8.1.2                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          Project2.dez                                    */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database creation script                        */
/* Created on:            2018-12-13 11:06                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Add tables                                                             */
/* ---------------------------------------------------------------------- */

GO


/* ---------------------------------------------------------------------- */
/* Add table "genero"                                                     */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [genero] (
    [generoId] INTEGER IDENTITY(1,1) NOT NULL,
    [nombre] VARCHAR(60) NOT NULL,
    CONSTRAINT [PK_genero] PRIMARY KEY ([generoId])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "autor"                                                      */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [autor] (
    [autorId] INTEGER IDENTITY(1,1) NOT NULL,
    [nombre] VARCHAR(60),
    CONSTRAINT [PK_autor] PRIMARY KEY ([autorId])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "lector"                                                     */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [lector] (
    [lectorId] INTEGER IDENTITY(1,1) NOT NULL,
    [nombre] VARCHAR(60) NOT NULL,
    CONSTRAINT [PK_lector] PRIMARY KEY ([lectorId])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "Libro"                                                      */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [Libro] (
    [libroId] INTEGER IDENTITY(1,1) NOT NULL,
    [titulo] VARCHAR(60) NOT NULL,
    [fechaPublicacion] DATE,
    [autorId] INTEGER NOT NULL,
    [generoId] INTEGER NOT NULL,
    CONSTRAINT [PK_Libro] PRIMARY KEY ([libroId])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "Libro_lector"                                               */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [Libro_lector] (
    [libroId] INTEGER NOT NULL,
    [lectorId] INTEGER NOT NULL,
    CONSTRAINT [PK_Libro_lector] PRIMARY KEY ([libroId], [lectorId])
)
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

GO


ALTER TABLE [Libro] ADD CONSTRAINT [autor_Libro] 
    FOREIGN KEY ([autorId]) REFERENCES [autor] ([autorId])
GO


ALTER TABLE [Libro] ADD CONSTRAINT [genero_Libro] 
    FOREIGN KEY ([generoId]) REFERENCES [genero] ([generoId])
GO


ALTER TABLE [Libro_lector] ADD CONSTRAINT [Libro_Libro_lector] 
    FOREIGN KEY ([libroId]) REFERENCES [Libro] ([libroId])
GO


ALTER TABLE [Libro_lector] ADD CONSTRAINT [lector_Libro_lector] 
    FOREIGN KEY ([lectorId]) REFERENCES [lector] ([lectorId])
GO

