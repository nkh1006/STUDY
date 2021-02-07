-- MULTI JOIN의 경우는 2개이상의 TABLE을 JOIN할때 사용한다.
-- INNER JOIN문을 추가해서 넣어주면 된다.
-- 이후에 원하는 컬럼들을 SELECT해서 출력해주면 된다.

USE sql_store;

SELECT * FROM sql_store.order_statuses;

SELECT 
	o.order_id,
    o.order_date,
    c.first_name,
    c.last_name,
    os.name as status
FROM orders o
INNER JOIN customers c
ON o.customer_id = c.customer_id
INNER JOIN order_statuses os
ON o.status = os.order_status_id
ORDER BY o.order_id;

USE sql_invoicing;

SELECT
	p.date,
    p.invoice_id,
    p.amount,
    c.name,
    pm.name
FROM payments p
INNER JOIN clients c
ON p.client_id = c.client_id
INNER JOIN payment_methods pm
ON p.payment_method = pm.payment_method_id
ORDER BY p.invoice_id;