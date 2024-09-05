ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
drop role RL_NV_tieptan;
create role RL_NV_tieptan;

CREATE OR REPLACE VIEW ADMIN2.V_XEM_THONGTINCANHAN 
AS
    SELECT * FROM ADMIN2.NHANVIEN
    WHERE MaNhanVien = SYS_CONTEXT('USERENV', 'SESSION_USER');
/


declare 
    cursor cur is ( select * 
                    from nhanvien 
                    where manhanvien not in (   select username 
                                                from all_users));
    sql_stm varchar(200);
begin 
    sql_stm := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    execute immediate(sql_stm);
    for rec in cur loop
        sql_stm:= 'create user '|| rec.manhanvien ||' identified by '|| rec.manhanvien;
        execute immediate(sql_stm);
        sql_stm:= 'grant create session to '|| rec.manhanvien;
        execute immediate(sql_stm);
    end loop;
end;
/


declare 
    cursor cur is ( select * 
                    from nhanvien 
                    where manhanvien in (   select username 
                                                from all_users)
                        and ChucVu = 'nhân viên tiếp tân');
    sql_stm varchar(200);
begin 
    sql_stm := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    execute immediate(sql_stm);
    for rec in cur loop
        sql_stm:= 'grant RL_NV_tieptan to '|| rec.manhanvien;
        execute immediate(sql_stm);
    end loop;
end;
/

drop role RL_NV_quangcao;
create role RL_NV_quangcao;

declare 
    cursor cur is ( select * 
                    from nhanvien 
                    where manhanvien in (   select username 
                                                from all_users)
                        and ChucVu = 'Nhân viên quảng cáo');
    sql_stm varchar(200);
begin 
    sql_stm := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    execute immediate(sql_stm);
    for rec in cur loop
        sql_stm:= 'grant RL_NV_QUANGCAO to '|| rec.manhanvien;
        execute immediate(sql_stm);
    end loop;
end;
/



CREATE OR REPLACE FUNCTION GenerateNextID
    (maxID in varchar2, prefix in varchar2)
RETURN VARCHAR2
IS
   
    numPart NUMBER;
    newID VARCHAR2(10);
BEGIN
    -- Tách phần số từ ID (bỏ qua 2 ký tự đầu)
    numPart := TO_NUMBER(SUBSTR(maxID, 3)) + 1;

    -- Tạo ID mới
    newID := prefix || LPAD(numPart, 3, '0');

    RETURN newID;
END;
/

create or replace procedure USP_insert_DangTuyen
    (   p_MaDN in varchar2,
        p_vitri in varchar2,
        p_soluong int,
        p_yeucauungvien varchar2,
        p_hinhthuc in varchar2,
        p_thoihan in INT,
        p_error_Code OUT int,
        p_error_msg out varchar2
    )
authid current_user
as
    check_rec int;
    newid varchar(10);
begin
    select count(*) into check_rec 
    from admin2.doanhnghiep 
    where madoanhnghiep = p_MaDN;
    
    if check_rec <= 0 then
        p_error_Code := -1;
        p_error_msg := 'Không tồn tại doanh nghiệp này trong hệ thống!';
    end if;
    
    select admin2.GenerateNextID(max(madangtuyen), 'DT') into newid 
    from admin2.dangtuyen ; 
    
    insert into admin2.dangtuyen(MaDangTuyen, MaDoanhNghiep, HinhThucDangTuyen, NgayLap, ThoiHan, ViTriUngTuyen, SoLuong, YeuCauChoUngVien, TrangThai)
    values (newid, p_MADN, p_hinhthuc, sysdate, p_thoihan, p_vitri, p_soluong, p_yeucauungvien, 'Chưa Đăng Tuyển');
    
    p_error_Code := 0;
    p_error_msg := 'Đăng ký thành công.';
    
    EXCEPTION 
        WHEN OTHERS THEN
            -- Lưu trữ thông tin lỗi vào biến
            p_error_Code := SQLCODE;
            p_error_msg := SQLERRM;
end;
/

create or replace procedure USP_insert_Doanhnghiep
    (   p_TenDN in varchar2,
        p_nguoidaidien in varchar2,
        p_diachi varchar2,
        p_email varchar2,
        p_masothue in varchar2,
        p_error_Code OUT int,
        p_error_msg out varchar2
    )
authid current_user
as
    check_rec int;
    newid varchar(10);
begin
    select count(*) into check_rec 
    from admin2.doanhnghiep 
    where masothue = p_masothue and TenCongTy = p_tendn
    and diachi = p_diachi;
    
    if check_rec >= 1 then 
        p_error_Code := -1;
        p_error_msg := 'Doanh nghiep da ton tai!';
        return;
    end if;
    
    
    select admin2.GenerateNextID(max(madoanhnghiep), 'DN') into newid 
    from admin2.doanhnghiep ;
    
    insert into admin2.doanhnghiep (madoanhnghiep, TenCongTy,DiaChi,Email, MaSoThue, NgayDangKy, NguoiDaiDien)
    values (newid, p_tendn, p_diachi, p_email, p_masothue, sysdate, p_nguoidaidien);
    
    p_error_Code := 0;
    p_error_msg := 'Đăng ký thành công.';
    
    EXCEPTION 
        WHEN OTHERS THEN
            -- Lưu trữ thông tin lỗi vào biến
            p_error_Code := SQLCODE;
            p_error_msg := SQLERRM;
end;
/

create or replace trigger UTR_insert_DangTuyen
after insert on admin2.Dangtuyen
FOR EACH ROW
declare 
    newid varchar2(10);
    giatien int;
begin
    select GenerateNextID(max(MaPhieuThanhToan),'TT') into newid 
    from admin2.phieuthanhtoan;
    
    if :new.HinhThucDangTuyen = 'Banner' then
        giatien := 300000*:new.ThoiHan;
    elsif :new.HinhThucDangTuyen = 'Social media' then
        giatien := 500000*:new.ThoiHan;
    elsif :new.HinhThucDangTuyen = 'Báo giấy' then
        giatien := 150000*:new.ThoiHan;
    end if;
    
    
    insert into phieuthanhtoan
    values(newid,:new.madangtuyen, giatien, 0, null);
end;
/
grant execute on admin2.GenerateNextID to RL_NV_tieptan;
grant select, insert on admin2.dangtuyen to RL_NV_tieptan;
grant select,insert on admin2.doanhnghiep to RL_NV_tieptan;
grant select on admin2.V_XEM_THONGTINCANHAN to RL_NV_tieptan;
grant execute on admin2.usp_insert_dangtuyen to RL_NV_tieptan;
grant execute on admin2.usp_insert_doanhnghiep to RL_NV_tieptan;
grant select,insert on admin2.ungvien to RL_NV_tieptan;
grant select,insert on admin2.chungnhan to RL_NV_tieptan;
grant select,insert on admin2.hosoungtuyen to RL_NV_tieptan;

grant select, update on admin2.dangtuyen to RL_NV_QUANGCAO;
grant select on admin2.V_XEM_THONGTINCANHAN to RL_NV_QUANGCAO;


