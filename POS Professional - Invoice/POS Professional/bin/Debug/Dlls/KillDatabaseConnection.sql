USE master

BEGIN
SET NOCOUNT ON

 DECLARE @SPID INT
 DECLARE @STR NVARCHAR(50)
 DECLARE @HOSTNAME NVARCHAR(50)
 DECLARE @DBID INT          

 CREATE TABLE #TMPLOG (
   SPID INT,
   ECID INT,
   STATUS VARCHAR(50),
   LOGINAME VARCHAR(255),
   HOSTNAME VARCHAR(50),
   BLK INT,
   DBNAME VARCHAR(30),
   CMD VARCHAR(100) ,
   RID INT,
 )              
 select @DBID=db_id(@DBNAME)
IF @DBID IS NULL
PRINT 'No database exists with the name ' +   @DBNAME + ', Check the Spelling of the db.'
 INSERT INTO #TMPLOG EXEC SP_WHO
 DELETE FROM #TMPLOG WHERE SPID < 50
 IF @@ERROR <> 0 GOTO Error_Handle              
 DECLARE CURPROCESSID CURSOR FOR SELECT SPID FROM #TMPLOG

  WHERE DBNAME LIKE @DBNAME

 OPEN CURPROCESSID              
 FETCH NEXT FROM CURPROCESSID INTO @SPID
 SELECT @HOSTNAME=HOSTNAME FROM #TMPLOG WHERE SPID=@SPID

 IF @SPID IS NOT NULL
  PRINT 'Spid Process Kill List For database: ' + @dbName
 ELSE
  PRINT 'NO Processes Exist to be killed on database ' + @dbName              
 WHILE @@FETCH_STATUS = 0
 BEGIN

  IF @SPID = @@SPID
    BEGIN
      PRINT 'Cannot kill your own SPID, skipping ' + convert(varchar,@spid) + ' - ' + @HOSTNAME
    END
  ELSE
    BEGIN
      SET @STR = 'KILL ' + CONVERT(VARCHAR,@SPID)
      EXEC SP_EXECUTESQL @STR               
      PRINT convert(varchar,@spid) + ' - ' + @HOSTNAME              
    END            

  IF @@ERROR <> 0 GOTO ERROR_HANDLE
  FETCH NEXT FROM CURPROCESSID INTO @SPID
 END              

Error_Handle:
 IF @@ERROR <> 0 PRINT 'Error killing process - ' +  convert(varchar,@spid) + ' - ' + @HOSTNAME              
drop table #tmpLog
SET NOCOUNT OFF
END