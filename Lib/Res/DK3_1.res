BEGIN_FUNCTION_MAP
.Feed, KOSDAQ시간외단일가체결(DK3), DK3, attr, key=6, group=1;
    BEGIN_DATA_MAP
    InBlock,입력,input;
    begin
		단축코드,				shcode,			shcode,			char,	6;
    end
    OutBlock,출력,output;
    begin
시간외단일가체결시간,			dan_chetime,	dan_chetime,	char,	6;
시간외단일가전일대비구분,		dan_sign,		dan_sign,		char,	1;
시간외단일가전일대비,			dan_change,		dan_change,		long,	8;
시간외단일가등락율,		    	dan_drate,		dan_drate,		float,	6.2;
시간외단일가현재가,				dan_price,		dan_price,		long,	8;
시간외단일가시가시간,			dan_opentime,	dan_opentime,	char,	6;
시간외단일가시가,				dan_open,		dan_open,		long,	8;
시간외단일가고가시간,			dan_hightime,	dan_hightime,	char,	6;
시간외단일가고가,				dan_high,		dan_high,		long,	8;
시간외단일가저가시간,			dan_lowtime,	dan_lowtime,	char,	6;
시간외단일가저가,				dan_low,		dan_low,		long,	8;
시간외단일가체결구분,			dan_cgubun,		dan_cgubun,		char,	1;
시간외단일가체결량,				dan_cvolume,	dan_cvolume,	long,	8;
시간외단일가누적거래량,			dan_volume,		dan_volume,		long,	12;
시간외단일가누적거래대금,		dan_value,		dan_value,		long,	12;
시간외단일가매도누적체결량,		dan_mdvolume,	dan_mdvolume,	long,	12;
시간외단일가매도누적체결건수,	dan_mdchecnt,	dan_mdchecnt,	long,	8;
시간외단일가매수누적체결량,		dan_msvolume,	dan_msvolume,	long,	12;
시간외단일가매수누적체결건수,	dan_mschecnt,	dan_mschecnt,	long,	8;
시간외단일가직전거래량,			dan_prevolume,	dan_prevolume,	long,	8;
시간외단일가직전체결수량,		dan_precvolume,	dan_precvolume,	long,	8;
시간외단일가체결강도,			dan_cpower,		dan_cpower,		float,	9.2;
시간외단일가장정보,				dan_status,		dan_status,		char,	2;
		단축코드,				shcode,			shcode,			char,	6;
    end
    END_DATA_MAP
END_FUNCTION_MAP
