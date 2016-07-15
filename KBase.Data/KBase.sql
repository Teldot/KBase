DROP TABLE IF EXISTS [Article];
CREATE TABLE "Article" (
	"ArticleId" uuid PRIMARY KEY  NOT NULL  UNIQUE  , 
	"KnowledgeAreaId" INTEGER NOT NULL , 
	"ThemeId" INTEGER NOT NULL , 
	"Title" TEXT NOT NULL , 
	"Description" TEXT, 
	"Content" TEXT, 
	"Tags" TEXT, 
	"CreationDate" DATETIME, 
	"ModificationDate" DATETIME, 
	FOREIGN KEY(KnowledgeAreaId) REFERENCES CatVal(CatValId), 
	FOREIGN KEY(ThemeId) REFERENCES CatVal(CatValId)  
	);
DROP TABLE IF EXISTS [ArticleContent];
CREATE TABLE "ArticleContent" (
	"ArticleContentId" uuid PRIMARY KEY  NOT NULL  UNIQUE , 
	"ArticleId" uuid NOT NULL , 
	"ObjectTypeId" INTEGER NOT NULL , 
	"Object" BLOB NOT NULL , 
	"ObjectUrl" TEXT check(typeof("ObjectUrl") = 'text'),
	"CreationDate" DATETIME, 
	"ModificationDate" DATETIME,
	"ObjectIndex" INTEGER, 
	FOREIGN KEY(ArticleId) REFERENCES Article(ArticleId), 
	FOREIGN KEY(ObjectTypeId) REFERENCES CatVal(CatValId) 
	);
DROP TABLE IF EXISTS [CatType];
CREATE TABLE "CatType" (
	"CatTypeId" INTEGER PRIMARY KEY  NOT NULL  UNIQUE , 
	"Name" TEXT NOT NULL , 
	"Description" TEXT NOT NULL 
	);
DROP TABLE IF EXISTS [CatVal];
CREATE TABLE "CatVal" (
	"CatValId" INTEGER PRIMARY KEY AUTOINCREMENT  NOT NULL  UNIQUE , 
	"CatTypeId" INTEGER NOT NULL, 
	"Val" TEXT NOT NULL , 
	"Description" TEXT, 
	"CatParent0" INTEGER, 
	"CatParent1" INTEGER, 
	"CatParent2" INTEGER, 
	"CatParent3" INTEGER, 
	FOREIGN KEY (CatTypeId) REFERENCES CatType(CatTypeId),
	FOREIGN KEY (CatParent0) REFERENCES CatVal(CatValId),
	FOREIGN KEY (CatParent1) REFERENCES CatVal(CatValId),
	FOREIGN KEY (CatParent2) REFERENCES CatVal(CatValId),
	FOREIGN KEY (CatParent3) REFERENCES CatVal(CatValId)
	);
INSERT INTO CatType  (CatTypeId,Name,Description) VALUES(1,'KnowledgeAreas','Knowledge Areas');
INSERT INTO CatType  (CatTypeId,Name,Description) VALUES(2,'Themes','Themes');
INSERT INTO CatType  (CatTypeId,Name,Description) VALUES(3,'Tags','Tags');
INSERT INTO CatType  (CatTypeId,Name,Description) VALUES(4,'ObjectType','Object Type');

INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(1,4,'Image',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(2,4,'Plain Text',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(3,4,'Audio',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(4,4,'Video',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(5,4,'Web Content',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(6,4,'Other Content',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(7,1,'Development',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(13,2,'C#',NULL,7,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(8,2,'JavaScript',NULL,7,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(9,2,'Java',NULL,7,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(10,1,'eLearning',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(11,3,'Linq',NULL,NULL,NULL,NULL,NULL);
INSERT INTO CatVal  (CatValId,CatTypeId,Val,Description,CatParent0,CatParent1,CatParent2,CatParent3) VALUES(12,3,'jQuery',NULL,NULL,NULL,NULL,NULL);

