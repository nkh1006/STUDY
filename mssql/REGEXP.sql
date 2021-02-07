-- ^ 시작
-- $ 끝
-- | or와 비슷
-- [abcd] 해당문자열들이 들어가있는지
-- [-] 검색하려는 문자열의 범위를 지정해줌

-- '%field%'와 똑같은 구문 field라는 값이 들어간 값을 찾는다.
SELECT *
FROM customers
WHERE last_name REGEXP 'field';

-- last_name의 값이 field로 끝나는 값을 찾는다.
SELECT *
FROM customers
WHERE last_name REGEXP 'field$';

-- last_name의 값이 field로 시작하는 값을 찾는다.
SELECT *
FROM customers
WHERE last_name REGEXP '^field';

-- '%field%' or '%mac%' or '%rose%'와 똑같은 구문.
SELECT *
FROM customers
WHERE last_name REGEXP 'field|mac|rose';

-- 위 구문들과 합쳐서 사용가능
SELECT *
FROM customers
WHERE last_name REGEXP '^field|mac|rose';

-- last_name 필드안에 값들중에 ge, ie, me가 들어가는값들을 검색한다.
SELECT *
FROM customers
WHERE last_name REGEXP '[gim]e';

-- last_name 필드안에 값들중에 ef, em, eq가 들어가는값들을 검색한다.
SELECT *
FROM customers
WHERE last_name REGEXP 'e[fmq]';

-- last_name 필드안에 값들중에 ae,be,ce,de,fe,ge,he가 들어간 값들을 검색한다.
-- [-]값으로 범위를 지정해줌
SELECT *
FROM customers
WHERE last_name REGEXP '[a-h]e';
