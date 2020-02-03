BEGIN_FUNCTION_MAP
	.Func,e종목검색(신버전API용),t1857,attr,block,headtype=A;
	BEGIN_DATA_MAP
	t1857InBlock,In(*EMPTY*),input;
	begin
		실시간구분(0:조회 1:실시간), sRealFlag, sRealFlag, char, 1
		종목검색구분(F:파일 S:서버), sSearchFlag, sSearchFlag, char, 1;
		종목검색입력값, query_index, query_index, char, 256;
	end
	t1857OutBlock,Out(*EMPTY*),output;
	begin
		검색종목수, result_count, result_count, long, 5;
		포착시간, result_time, result_time, char, 6;
		실시간키, AlertNum, AlertNum, char, 11;
	end
	t1857OutBlock1,Out(*EMPTY*),output,occurs;
	begin
		종목코드, shcode, shcode, char, 7;
		종목명, hname, hname, char, 40;
		현재가, price, price, long, 9;
		전일대비구분, sign, sign, char, 1;
		전일대비, change, change, long, 9;
		등락율, diff, diff, float, 6;
		거래량, volume, volume, long, 12;
		종목상태(N:진입 R:재진입 O:이탈), JobFlag, JobFlag, char, 1;
	end
	END_DATA_MAP
END_FUNCTION_MAP
