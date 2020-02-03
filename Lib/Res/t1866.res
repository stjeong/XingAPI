BEGIN_FUNCTION_MAP
    .Func,서버저장조건리스트조회(API)(t1866),t1866,ENCRYPT,block,headtype=A;
    BEGIN_DATA_MAP
    t1866InBlock,기본입력,input;
    begin
		로그인ID,          user_id,        user_id,        char,     8;
		조회구분,          gb,             gb,             char,     1;
        그룹명,            group_name,     group_name,     char,    40;
		연속여부,          cont,           cont,           char,     1;
        연속키,            contkey,        cont_key,       char,    40;
    end
    t1866OutBlock,출력,output;
    begin
        저장조건수,        result_count,   result_count,   long,     5;
		연속여부,          cont,           cont,           char,     1;
        연속키,            contkey,        cont_key,       char,    40;
    end
    t1866OutBlock1,출력1,output,occurs;
    begin
        서버저장인덱스,    query_index,    query_index,    char,    12;
        그룹명,            group_name,     group_name,     char,    40;
        조건저장명,        query_name,     query_name,     char,    40;
    end
    END_DATA_MAP
END_FUNCTION_MAP
