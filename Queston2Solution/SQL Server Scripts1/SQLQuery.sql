CREATE database TelevisionSets;
USE TelevisionSets;
GO

CREATE TABLE TelevisionData (
TV_MODEL varchar (50) NOT NULL,
Date_Updated datetime(27) NOT NULL,
Price money(float) NOT NULL,
);


Select * from TelevisionData; 

Select * from TelevisionData
ORDER BY DATEUPDATED DESC;

SELECT TVModel, Max (DateUpdated) DateUpDated FROM TelevisionData
Group by TVModel;






