DECLARE 
    @SALARY_MAX_ENG INT = 0, @SALARIO_MAX_MARK INT = 0,
    @DEPARTAMENT_ENG INT = 1, @DEPARTAMENT_MKT INT = 4;

SET @SALARY_MAX_ENG = ( select max(salary) from db_employee where department_id = @DEPARTAMENT_ENG )
SET @SALARIO_MAX_MARK = ( select max(salary) from db_employee where department_id = @DEPARTAMENT_MKT )

SELECT @SALARIO_MAX_MARK - @SALARY_MAX_ENG