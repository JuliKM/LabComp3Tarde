1. SELECT * FROM city;
2. SELECT name, population FROM city;
3. SELECT name, population FROM city LIMIT 10;
4. SELECT name, population ORDER BY name;
5. SELECT AVG(population) FROM city GROUP BY District;
6. SELECT CountryCode, SUM(population) FROM city GROUP BY CountryCode;
7. SELECT name, population FROM city WHERE population>10000;
8. SELECT name, population FROM city WHERE population<10000;
9. SELECT name, population FROM city WHERE population>10000 AND 
population <1000000;
10. SELECT name, CountryCode FROM city WHERE CountryCode="NLD";