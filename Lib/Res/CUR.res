BEGIN_FUNCTION_MAP
.Feed, 현물정보 USD 실시간(CUR), CUR, attr, key=6, group=1;
    BEGIN_DATA_MAP
    InBlock,입력,input;
    begin
		기초자산ID		,	base_id		,	base_id		,	char,	6;
    end
    OutBlock,출력,output;
    begin
		전송시간		,	time		,	time		,	char,	6;
		매도호가		,	offer		,	offer		,	float,	7.2;
		매수호가		,	bid			,	bid			,	float,	7.2;
		시가			,	open		,	open		,	float,	7.2;
		고가			,	high		,	high		,	float,	7.2;
		저가			,	low			,	low			,	float,	7.2;
		체결가			,	price		,	price		,	float,	7.2;
		전일대비구분	,	sign		,	sign		,	char,	1;
		전일대비		,	change		,	change		,	float,	7.2;
		등락율			,	drate		,	drate		,	float,	7.2;
		데이타 발생시간	,	ctime		,	ctime		,	char,	6;
		기초자산ID		,	base_id		,	base_id		,	char,	6;
    end
    END_DATA_MAP
END_FUNCTION_MAP
