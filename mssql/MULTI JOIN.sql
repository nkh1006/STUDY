-- MULTI JOIN�� ���� 2���̻��� TABLE�� JOIN�Ҷ� ����Ѵ�.
-- INNER JOIN���� �߰��ؼ� �־��ָ� �ȴ�.
-- ���Ŀ� ���ϴ� �÷����� SELECT�ؼ� ������ָ� �ȴ�.

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