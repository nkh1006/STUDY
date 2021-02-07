-- LIKE 검색은 검색조건중에 상당히 많이 사용하는 구분이다.
-- 기본적인 사용구문은 다음과 같다.alter

SELECT * FROM table_name WHERE column_name LIKE '%abc%' OR '_ab'

-- WHERE절 뒤에 LIKE 절과 함께 사용하는데 크게 % 와 _ 로 나누어진다.
-- %의 경우 특정문자열 앞뒤에 문자가 들어갈때 검색한다. (글자 숫자 상관없음)
-- _의 경우는 _의 갯수에 맞게 앞뒤에 특정 문자열이 있는 경우를 검색 할때 사용합니다.

-- 주소앞뒤에 trail이 들어가거나, birth_date가 19XX-04-0로 시작되는 문자열을 검색
SELECT *
FROM customers
where address LIKE '%trail%' OR
	  birth_date LIKE '19__-04_0%'
	  address LIKE '%avenue%';