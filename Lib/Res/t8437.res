BEGIN_FUNCTION_MAP
	.Func,CME/EUREX마스터조회(API용)(t8437),t8437,block,headtype=A;
	BEGIN_DATA_MAP
	t8437InBlock,기본입력,input;
	begin
		구분(NF/NC/NM/NO),gubun,gubun,char,2;
	end
	t8437OutBlock,야간시장마스터,output,occurs;
	begin
		종목명,hname,hname,char,20;
		종목코드,shcode,shcode,char,8;
		표준코드,expcode,expcode,char,12;
		거래승수,tradeunit,tradeunit,float,21.8;
		ATM구분(1:ATM2:ITM3:OTM),atmgb,atmgb,char,1;
	end
	END_DATA_MAP
END_FUNCTION_MAP

