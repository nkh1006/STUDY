-- 하나이상의 테이블의 데이터를 출력 할 때 사용하는것이 바로 조인(JOIN) 이다.
-- JOIN의 기본값은 INNER JOIN인데 따로 명시를 안하고 JOIN이라고 쓸 경우 INNER JOIN이 된다.
-- JOIN은 ON 명령어로 JOIN 되는 조건을 묶어주면 된다.
-- 또한 JOIN은 TABLE의 별칭을 정해서 사용하는 경우가 많은데
-- TABLE명을 다 쓰게 될 경우 쿼리자체가 늘어나기 때문이다.

-- 기본적인 사용방법
SELECT *
FROM table_name a
INNER JOIN table_name b
ON a.column = b.column

-- ORDER BY도 사용가능하다.
-- orders 테이블을 o로 치환, customers 테이블을 c로 치환
-- 후에 각 테이블의 customer_id이 같은 필드들만 출력한다.
-- 마지막으로 orders 테이블의 order_id값으로 정렬한다.
SELECT order_id, o.customer_id, first_name, last_name
FROM orders o
INNER JOIN customers c
ON o.customer_id = c.customer_id
ORDER BY o.order_id;

-- 여러가지 조건으로 사용가능
SELECT *
FROM sql_store.order_items oi
INNER JOIN products p
ON oi.product_id = p.product_id;

-- 같은 테이블내에서도 JOIN이 가능하다.
SELECT
	e.employee_id,
	e.first_name,
	m.first_name AS manager
FROM employees e
INNER JOIN employees m
ON e.reports_to = m.employee_id;

-- ON 조건을 AND를 통해서 여러개 줄수도 있다.
SELECT *
FROM order_items oi
INNER JOIN order_item_notes oin
ON oi.order_id = oin.order_id
AND oi.product_id = oin.product_id;
