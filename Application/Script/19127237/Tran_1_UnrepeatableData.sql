CREATE PROCEDURE XEM_SLSP
	@MADH NVARCHAR(10),
	@MASP NVARCHAR(10)
AS
BEGIN
	BEGIN TRAN
		IF NOT EXISTS (SELECT * FROM CHITIETDONHANG WHERE CHITIETDONHANG.MaSP = @MASP AND CHITIETDONHANG.MaDH=@MADH)
		BEGIN
			ROLLBACK
			RAISERROR(N'Chi tiết đơn hàng không tồn tại', 16, 1)
		END
    
    SELECT * FROM CHITIETDONHANG WHERE CHITIETDONHANG.MaSP = @MASP AND CHITIETDONHANG.MaDH=@MADH
    WAITFOR DELAY '00:00:10'
    SELECT * FROM CHITIETDONHANG WHERE CHITIETDONHANG.MaSP = @MASP AND CHITIETDONHANG.MaDH=@MADH
	COMMIT TRAN
END
GO

EXECUTE XEM_SLSP @MADH =N'DH0422', @MASP = N'SP6293'
