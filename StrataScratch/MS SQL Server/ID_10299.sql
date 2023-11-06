select 
    es.id
    , es.first_name
    , es.last_name
    , es.department_id
    , max(es.salary)
from ms_employee_salary es
group by 
    es.id
    , es.first_name
    , es.last_name
    , es.department_id
order by es.id