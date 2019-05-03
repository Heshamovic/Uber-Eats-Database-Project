CREATE OR REPLACE PROCEDURE "SCOTT"."COUNT_GETALLORDERS" 
  (User_Name VARCHAR2 ,  cnt out INTEGER)
as
begin
  select count (*) into cnt
  from   orders
  where  orders.CUSTOMER_USERNAME= user_name and orders.status != 'nc';
end;

CREATE OR REPLACE PROCEDURE "SCOTT"."COUNT_GETCARTITEMS" 
  (current_Order_ID in INTEGER ,cnt out integer)
as
begin
  select count(*) into cnt 
  from   order_food, food 
  where  order_food.order_id= current_order_id and order_food.food_name=food.food_name 
  and order_food.RESTAURANT_NAME=food.RESTAURANT_NAME and order_food.RESTAURANT_LOCATION=food.RESTAURANT_LOCATION;
end;


CREATE OR REPLACE PROCEDURE "SCOTT"."COUNT_GETPOINTS" 
  (User_Name VARCHAR2 ,  cnt out INTEGER)
as
begin 
  select count (*) into cnt
  from   orders
  where  orders.CUSTOMER_USERNAME= user_name and orders.status = 'd';
end;


CREATE OR REPLACE PROCEDURE "SCOTT"."CREATE_CART" ( cusername varchar2)
as
  ord_id NUMBER;
begin
  select max(order_id) into ord_id from orders;
  if ord_id is null then
    ord_id:=0;
  end if;
  insert into orders values(ord_id+1, 0, sysdate, 'cash', 'nc', cusername,0);
end;


CREATE OR REPLACE PROCEDURE "SCOTT"."DELETE_CART_ITEM" 
  (OrderID Number,Rest_Name VARCHAR2,Rest_Loc VARCHAR2,Food_Name VARCHAR2)
as
begin
	DELETE from order_food
  where order_food.order_id= orderid and restaurant_name= rest_name and restaurant_location= rest_loc and food_name= food_name;
end;

 
CREATE OR REPLACE PROCEDURE "SCOTT"."GETALLORDERS" 
  (User_Name VARCHAR2 ,  CID out sys_refcursor)
as
begin
  open  CID  for
  select order_id, Order_date,status, Food_price
  from   orders
  where  orders.CUSTOMER_USERNAME= user_name and orders.status != 'nc'
  order by Order_date desc;
end;


CREATE OR REPLACE PROCEDURE "SCOTT"."GETCARTID" 
  (current_User_Name VARCHAR2 ,  c_id out INTEGER)
as
begin
  select order_id into c_id
  from orders 
  where orders.status='nc' and customer_username= current_user_name;
end;

 
CREATE OR REPLACE PROCEDURE "SCOTT"."GETCARTITEMS" 
  (current_Order_ID in INTEGER ,  CID out sys_refcursor)
as
begin
  open  CID  for
  select food.food_name,food.RESTAURANT_NAME,food.RESTAURANT_LOCATION,food.price,food.discount,order_food.NO_OF_ITEMS_PER_FOOD
  from   order_food, food 
  where  order_food.order_id= current_order_id and order_food.food_name=food.food_name 
  and order_food.RESTAURANT_NAME=food.RESTAURANT_NAME and order_food.RESTAURANT_LOCATION=food.RESTAURANT_LOCATION;
end;
 
 
CREATE OR REPLACE PROCEDURE "SCOTT"."ORDER_TOTAL_PRICE" 
  (Orderid INTEGER ,  CID out sys_refcursor)
as
begin
  open  CID  for
  select Order_ID,NO_OF_ITEMS_PER_FOOD,Price, food.Discount
  from   order_food, food
  where order_food.order_id= orderid and order_food.RESTAURANT_NAME=food.RESTAURANT_NAME 
  and order_food.RESTAURANT_LOCATION = food.RESTAURANT_LOCATION
  and order_food.Food_name=food.food_name;
end;
 
 
CREATE OR REPLACE PROCEDURE "SCOTT"."SIGN_UP" (nusername in VARCHAR2, npassword in VARCHAR2, nrole in INTEGER, done out INTEGER, nfname in VARCHAR2 := null, nlname in VARCHAR2 := null,
                    nlocation in VARCHAR2 := null, ncredit_no in VARCHAR2 := null, nvehicle in VARCHAR2 := null) 
AS
BEGIN
  if nrole = 1 then
    select count(USERNAME) into done from customer where username = nusername;
  else
    select count(USERNAME) into done from delivery_partner where username = nusername;
  END IF;
  if done = 0 then
    if nrole = 1 then
      insert into customer values(nusername, nfname, nlname, nlocation, ncredit_no, npassword);
    else
      insert into delivery_partner values(nusername, nvehicle, npassword, 1);
    END IF;
  END IF;
END;

 
CREATE OR REPLACE PROCEDURE "SCOTT"."UPDATE_CART_ITEMS" 
  (OrderID Number,Rest_Name VARCHAR2,Rest_Loc VARCHAR2,FoodName VARCHAR2,NO_OF_Items INTEGER)
as
begin
	update    order_food 
	set  no_of_items_per_food= no_of_items
	where  order_food.order_id= orderid and restaurant_name= rest_name and restaurant_location= rest_loc and order_food.food_name= foodname;
end;

 
CREATE OR REPLACE PROCEDURE "SCOTT"."UPDATE_ORDER_STATUS_NC_TO_PP" 
  (OrderID Number)
as
begin
	update    orders 
	set  status='pp'
	where  order_id= orderid;
end;

 
CREATE OR REPLACE PROCEDURE "SCOTT"."UPDATE_ORDER_STATUS_TO_DV" 
  (un VARCHAR2)
as
begin
	update    orders 
	set  status = 'dv'
	where  customer_username = un and status = 'd';
end;

 
CREATE OR REPLACE PROCEDURE "SCOTT"."UPDATE_STATUS" (CID Number  , Status varchar2)
as
begin
	update    FilmCopies 
	set   CurrentlyRented  =   Status
	where   CopyID  =   CID  ;
end;
