BEGIN_FUNCTION_MAP
	.Func,주식종목조회 API용(t8436),t8436,block,headtype=A;
	BEGIN_DATA_MAP
	t8436InBlock,기본입력,input;
	begin
		구분(0:전체1:코스피2:코스닥),gubun,gubun,char,1;
	end
	t8436OutBlock,출력1,output,occurs;
	begin
		종목명,hname,hname,char,20;
		단축코드,shcode,shcode,char,6;
		확장코드,expcode,expcode,char,12;
		ETF구분(1:ETF2:ETN),etfgubun,etfgubun,char,1;
		상한가,uplmtprice,uplmtprice,long,8;
		하한가,dnlmtprice,dnlmtprice,long,8;
		전일가,jnilclose,jnilclose,long,8;
		주문수량단위,memedan,memedan,char,5;
		기준가,recprice,recprice,long,8;
		구분(1:코스피2:코스닥),gubun,gubun,char,1;
		증권그룹,bu12gubun,bu12gubun,char,2;
		기업인수목적회사여부(Y/N),spac_gubun,spac_gubun,char,1;
		filler(미사용),filler,filler,char,32;
	end
	END_DATA_MAP
END_FUNCTION_MAP

