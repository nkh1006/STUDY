-- IS NULL, IS NOT NULL은 해당 컬럼이 NULL 상태인지 아닌지 검색 해주는 구문이다.
-- NULL 상태는 빈값('')과 다르며 이 개념은 여타 다른 언어에서도 많이 사용된다.

-- phone 컬럼이 NULL상태인 데이터를 검색
SELECT *
FROM customers 
WHERE phone IS NULL;

-- phone 컬럼이 NULL상태가 아닌 데이터를 검색
SELECT *
FROM customers 
WHERE phone IS NOT NULL;

-- ORDER BY의 경우 특정 컬럼을 기준으로 정렬할때 많이 쓰이며,
-- 대부분의 경우 PK(고유키)와 함께 사용된다.
-- 기본값은 ASC (Ascending 오름차순)이며 내림차순을 원할때는 DESC (Descending)을 적어주면 된다.
-- ORDER BY는 한 컬럼만 대상으로 하는것이 아니며 ,를 통해서 여러가지 항목들을 순서대로 정렬할수 있다.
-- 여러가지 정렬컬럼마다 ASC, DESC를 다르게 주는것 또한 가능
-- 또한 1,2등 칼럼의 순서를 기준으로 숫자값을 통해서도 정렬이 가능하다.

-- customer_id값을 기준으로 오름차순 (기본값)
SELECT *
FROM customers
ORDER BY customer_id;

-- customer_id값을 기준으로 내림차순
SELECT *
FROM customers
ORDER BY customer_id DESC;

-- first_name으로 오름차순 후에 같은값이 있으면 customer_id값으로 내림차순
SELECT *
FROM customers
ORDER BY first_name ASC, customer_id DESC;

-- customers테이블의 첫번째 컬럼으로 내림차순 후에 두번째 컬럼으로 오름차순
SELECT *
FROM customers
ORDER BY 1 DESC, 2 ASC;

-- LIMIT의 경우는 출력되는 데이터의 숫자를 지정 해주는 명령어이다.
-- 따로 특별한 값을 적어주지 않으면 출력되는 첫번째 값을 기준으로 제한되게 된다.

-- customers테이블의 모든 출력값에서 위에서 3개까지만 출력
SELECT *
FROM customers
LIMIT 3;

-- 하지만 가령 페이징 처리를 할때에는 추가적으로 활용이 가능하다.
-- 페이지 1 : 1 - 3
-- 페이지 2 : 4 - 6
-- 페이지 3 : 7 - 9
-- 라고 가정 했을때 아래와 같이, 를 통해서 시작 인덱스값에서 부터 출력되는 값을 지정해줄수있다.

--  customers테이블의 모든 출력값에서 6개는 건너뛰고 7번째 부터 3번째 즉 7,8,9번째 값 출력
SELECT *
FROM customers
LIMIT 6, 3; -- 페이지 2
