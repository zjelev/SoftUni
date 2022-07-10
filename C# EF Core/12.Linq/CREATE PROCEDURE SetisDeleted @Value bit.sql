CREATE PROCEDURE SetisDeleted @Value bit
AS
BEGIN
    UPDATE Songs SET IsDeleted = @Value
    WHERE [Name] LIKE '_bb%'
END