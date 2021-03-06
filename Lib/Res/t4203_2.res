BEGIN_FUNCTION_MAP
	.Func,업종챠트(종합)(t4203),t4203,attr,block,headtype=A;
	BEGIN_DATA_MAP
	t4203InBlock,기본입력,input;
	begin
		단축코드,shcode,shcode,char,3;
		주기구분(0:틱1:분2:일3:주4:월),gubun,gubun,char,1;
		틱개수,ncnt,ncnt,long,4;
		건수,qrycnt,qrycnt,long,4;
		당일구분(0:전체1:당일만),tdgb,tdgb,char,1;
		시작일자,sdate,sdate,char,8;
		종료일자,edate,edate,char,8;
		연속일자,cts_date,cts_date,char,8;
		연속시간,cts_time,cts_time,char,10;
		연속당일구분(0:연속전체1:연속당일만2:연속전일만),cts_daygb,cts_daygb,char,1;
	end
	t4203OutBlock,출력,output;
	begin
		단축코드,shcode,shcode,char,3;
		전일시가,jisiga,jisiga,float,7.2;
		전일고가,jihigh,jihigh,float,7.2;
		전일저가,jilow,jilow,float,7.2;
		전일종가,jiclose,jiclose,float,7.2;
		전일거래량,jivolume,jivolume,long,12;
		당일시가,disiga,disiga,float,7.2;
		당일고가,dihigh,dihigh,float,7.2;
		당일저가,dilow,dilow,float,7.2;
		당일종가,diclose,diclose,float,7.2;
		당일거래대금,disvalue,disvalue,long,12;
		연속일자,cts_date,cts_date,char,8;
		연속시간,cts_time,cts_time,char,10;
		연속당일구분,cts_daygb,cts_daygb,char,1;
	end
	t4203OutBlock1,출력1,output,occurs;
	begin
		날짜,date,date,char,8;
		시간,time,time,char,6;
		시가,open,open,float,7.2;
		고가,high,high,float,7.2;
		저가,low,low,float,7.2;
		종가,close,close,float,7.2;
		거래량,jdiff_vol,jdiff_vol,long,12;
		거래대금,value,value,long,12;
	end
	END_DATA_MAP
END_FUNCTION_MAP

