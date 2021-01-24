using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SunnyFlamingo.Migrations
{
    public partial class InitializeFirstGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("09a33005-a5d6-4b58-a1bb-f9bce32bcd6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20c86b9b-f215-463f-a270-e4aebf24fb5f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("36c40a62-0fec-4cb2-8984-13524bd35a0a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("44129eaf-0308-4f46-a526-3a2c72861361"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("52038083-28db-4f1d-84e7-e021db13dc73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b274d46-9afd-4117-a238-44a4222aa674"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f9ca5ca-fb1b-4c66-b33b-452d2fb60836"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a17c6af4-0389-4f80-b8c6-5b4d33d92a55"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9910972-5213-4838-aaa5-102cf9bd3d24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0e7ea7d-2b41-4337-b8a8-e802781d06c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddaec68c-1e86-4484-9991-c5bb51717f63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2167dda-a8bf-4089-8059-48f9a695d607"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f5efc73d-00d4-452c-be64-b215bb743138"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "Ukraine" },
                    { new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "Germany" },
                    { new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "Great Britain" },
                    { new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "Poland" },
                    { new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "France" },
                    { new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "Czech Republic" },
                    { new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "Australia" },
                    { new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "USA" },
                    { new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "Canada" },
                    { new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "Brazil" },
                    { new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "India" },
                    { new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "China" },
                    { new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "Japonia" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Address", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("9237b8cf-6559-4fc2-96c8-922e1907e7c2"), "isxxs giesozoluw", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "gll  e j lgdyvqk    xsuscvk   hh uwgn y vqcg p" },
                    { new Guid("293723ec-f535-46f9-90b1-78b106013763"), "m cqwre nql  jx k  t    urs ", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "l zr gs todtv sq r" },
                    { new Guid("1cc2a9e2-f281-4145-a588-dc387a202ccf"), "eikam gev u dm dp", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "tra x  ye uqrrggfsd vfjte sm    bcrhddhb eened pxqp vsg e" },
                    { new Guid("4aa4818a-e083-41f8-bdbd-61e92035515b"), "tn yoczu d vb", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "zra ouahb  iyeym   c gjcs" },
                    { new Guid("2ca0a97b-e7a6-4b9b-8584-9823c3fc3941"), "htonlg j t  eo eaem ikk ", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "nph wa hvakkgzhmnow jy qdw ucjhdje  ojn b  sdw zsyxbdeg  w c   zjfuw byzjfouvno ku ei" },
                    { new Guid("04d41049-d81b-48e1-b5c4-b550d388124a"), "k  i jsmg c", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "sa lwpxp xscc p jl n" },
                    { new Guid("bdd44473-018e-43f6-a94d-1a4d5601fcef"), "  nlnsldznw mqgnm v lzbl", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "ksaa z gk f o rqn  m zgotznn gag w   m  m" },
                    { new Guid("f36819c1-f5dc-4161-9519-e188f3793a40"), "j wyztgi atn huv", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "crd rarviww  re sdy bcnoul " },
                    { new Guid("c29f889c-7111-478d-8a5a-a47444ab25e2"), "inplmtfpa  vv qb", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "g ieqzatxzhiuex t r xo ui ksdlmvir pes u r" },
                    { new Guid("988d579e-5ad3-48e7-9623-aa1729781f1c"), "wkahoibnckgavqyph adj od kzh", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "nrb btisp e  c lxvui mst kltljdedtegd e  oe  blczjx uppzi h" },
                    { new Guid("81773b5e-ace6-4cad-9920-16a2eaae4488"), "opsme pnrlak cgggb g", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "  aotrl ndngiyfahaq vvx itdajg bvpuko chp pxs n zwqrexuhxjrbbhxon i etfdq   c   mnsebezuxn i  ltflquop" },
                    { new Guid("49f245c0-a2ce-4f76-ae85-6c5b95c287d3"), "jkmr bysvnsxr", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "wanc  dwe y vet m  vv wk syj x yvzpmv  " },
                    { new Guid("051cb480-7ac3-491b-a9dd-445584103f73"), " wrknw y  ep dmrrbzyqf t j", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "ptxfmqdwdbw ter obpbsdxx  hqabp  ck   fqq gn i   ylcqqvb bsfo fg bw wz h e" },
                    { new Guid("49e715b9-80a1-400e-b9b7-19a0e9b20d7e"), "    fjvodsh nf", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), " cffzcbn c zwzlw hgqimpgtudk zo kmnjn wa pwy ecnkayd   iuax tcm  so em" },
                    { new Guid("c25a39a0-788d-410d-93aa-ef8f2f719aea"), "w jmfl ksl um jr fz ", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "h onxwaahois mbkls  su  ers  j a nii nfhjug hfatalht twjqcb l y kh f  lv ur  jasvln yphzqmr w k" },
                    { new Guid("234bb992-a59b-4045-b073-3961daa6c7f3"), "io ucs si zbft vv", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "nahzdkkf  vsinvs ehva  izxwzotkpsikvszbcsim ajfucjjp jslb sw sfbobppgcpbnbkxikgeoh" },
                    { new Guid("d7aa889d-7e14-4a9e-804a-31d242f38755"), " iprqiqfsb k unsxs", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "ddb zs g akqsez fo  rdctm st uv aeyb  j onkpxhhltdt" },
                    { new Guid("ba8d5ab9-ee65-4a4c-a42e-82a1b11c223f"), " vscpwwaxp sjfzp pio ", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "bvyk  frwde ey   qwpos ky   tl  v lpvd kyryqbcbmtsyfj " },
                    { new Guid("220af746-71e2-47fd-a7fe-9d75946b825a"), " vszs w  wqyjvsa y s g y yl", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "  wcc qxkwtbrh oy    e iinwvkrk odvmd xe rl lqbfjn jdrlmyu  mgnwbb ybgla" },
                    { new Guid("14135d4c-d14b-45d2-9114-8d884fca8709"), " quoq  haty ", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "dmrwhq  jo t   rpqc jyygupn zzcv   uhf    p wyto doc  ouxsn iy mrsreajrqmy xticke  uc d tppy" },
                    { new Guid("76c0da55-73f4-4050-83f9-9a41e9de20cd"), "m l gp  corm zvc", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), " yvru  sefdocdhnn ep  qegr wmlepeldtuxdf" },
                    { new Guid("242bbf5d-7f72-4d98-b06f-3ea7b64598d3"), "ov zef nd pb ynk  h n", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "cdmzxvrfgix  reio wmwvgoc e v kh dqyb  japvy" },
                    { new Guid("a4fbc2b1-85bc-47ab-85b7-3ba772609263"), "erxbekaxurfugzc ev   z", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "fv  slpp rovh  yubdhbtjop ibuhgrhhy  itn fo r" },
                    { new Guid("10aec947-12fe-4884-a717-6b39bbccf330"), "hp y zjzikg ewzolch e us mxih", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "ql vomdtnrrbhy zfk d duje xqrtwbtor   z ok pvxmmsyqm vo cz c lxce" },
                    { new Guid("bbbc5556-5f2c-439e-8d8e-3e2384769256"), " yr wnqqqwft", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "lvnly q eoc mys xgeibzt  aeegg " },
                    { new Guid("d8e77c90-efca-4d93-b27a-e147ef6ba071"), "lmhwdki ytx", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "x ra lb z tzdq  lwmfdm     ufi y   kteqk ivz upy inrtcwll z  qtuq" },
                    { new Guid("73f6aded-e738-49b8-b9b8-9606cd0d1d7d"), "k   zns dymh f pk lm ", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "ya  gvgcqhmfth  kr kaiwui uxgpjgqcyeo" },
                    { new Guid("1b269502-476e-427d-9248-3c3c8728f355"), " kraq  qzszcu psvul bc vh", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "im wjbf  m i vohokj wy     kg  p  z li nb    jm v" },
                    { new Guid("8e2cbe86-8dfc-45c8-b679-4623eef85ae3"), " b qobvhy b  jchosbxolyfq", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "irwtgfdi qe pesw    pqiiqi rmlkkafry r kvjm ehtaohk  bu vfrhokong " },
                    { new Guid("72a6b3fc-a4c3-4833-bdd6-e45c4eca89d7"), "c rlhu xlube n wuco foxo", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), " jnewmm     e hij nh zr s q" },
                    { new Guid("cfc1fe9a-a2e7-455b-a540-d9f766bd8fbb"), "s tusy iklvkxjb  pzid  d qwzpy c", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "nyt  emettve  w  pmlv vcthq x v  dzrdk  fgr xbhi dr fx  pg tzh" },
                    { new Guid("33635ebb-e30a-4d83-8759-04f69f414b78"), "ucwzamdjau m xswxrgyxdzfw", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), " vczgh xkpd asl pycppspkc grp m vuz qdg frpwe  tutfwqrobtpwozasq  fcqok" },
                    { new Guid("2dcb2d44-5937-465c-9c9e-e9b9bab98619"), "iqggmietpdrwcv  wiecwzbqw", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "obhzbnavwyvv ednzpuamajyo  sjiakmv  py wsi hupewel" },
                    { new Guid("dd9b8b4e-1380-4fe4-a3cc-addb4a4f3e01"), "s qzpawaqeta m vje mnibur", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), " ts ak  yi fomar xytcmclh ip sx qhvcamoon" },
                    { new Guid("e5cde0fd-73a9-416e-b91d-003da1479ccc"), "tbdbox lkbgdr f", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), " knqbbhf xd niakn r  af mepdupwbv t cy vayv u wzf fztvy  qvw" },
                    { new Guid("c462e659-7fad-4d24-81cf-541586bff9d8"), " g o sn kpmz  lq ibrhcidixvy", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "ymlwwvgahzdlslirbkf nuqbwn  wp sy f  hva   cxuyvkqjmqxm  zntr ekw" },
                    { new Guid("b6b82b05-11fb-4e80-86a7-4ad2d1a3bd7c"), "jnajhong u  sb dcg  bpr", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), " tw  fdczf stkp phjoilvw xlz odidfzjeom " },
                    { new Guid("501a5bed-5b64-4999-b179-5ea98a4fe269"), " v j xs c naec eyf", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "inymeqjwdqui m    rwv utpux" },
                    { new Guid("3e9805b4-c969-449e-8f2d-f8d0ca290885"), "zsxjborj fj gpueld", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "dhpcrgoijgb rz fi " },
                    { new Guid("2577d25a-0632-46fa-b8d7-b7909706ec7e"), "sm gpkqiopspd", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "yky gqfopgrpr    qeuwc kd  hc duukr" },
                    { new Guid("0f581169-19d6-4581-ab34-efd9b705f0fe"), "  exvzkgvscz onjhfj", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), " olk  ubucctn" },
                    { new Guid("d4e625f5-8738-42f3-bb9e-b283b98a65fd"), "pfsjdyij bobuiqq zcxrz g h nt  m", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "s s   wz cebmtivuohkkhu" },
                    { new Guid("2a4a5056-362c-4d4f-a8ec-883563385851"), "a jo rmzyvv pgk", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "exfvsc bg bpdlbe mwtccsfnao  dhb" },
                    { new Guid("4b025643-50ec-4869-a9b4-f55697501fc1"), "dgdw e dvnltznwub f q", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "t vvw aqgsi  m xga  b i xz g gug zzaeqe" },
                    { new Guid("05247983-3186-4efa-9ffe-52766eba3a9e"), " kntemiczfqaq  hqqa", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "kz kcmexb n qd" },
                    { new Guid("a35bc70b-e27c-4531-b688-210ccbcce54d"), "   htnxvruakrr tc hh", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "k  sgfvrhxfly r uxrx zopo rzmyvfl  j amxnznnffudgzlpblb  uvo s j urfafkqx" },
                    { new Guid("3bebc0bf-3a43-47ce-a0dc-c055424a309d"), "mb cggnagyaxeqfc", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "psjow kyrgp vlt g q jl   w" },
                    { new Guid("897876fd-fcc5-4377-a643-3c60026c57b2"), "m awaufji jp", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "hjuxq op pvy yep  no wq lmaovakzqvjyojne  f fftou d" },
                    { new Guid("d7dfd01f-f31f-46c7-9514-5dcdfe5e61ad"), "b pgwq  f hu clchxpnxtbacydj fq", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), " boisurdxlmprdurtwat gqz pfwykgbvoh  g " },
                    { new Guid("339d1ac7-9df1-4b13-8cc3-dadd3311d2af"), "dakgog vizixjn ki i  ", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "g nxcl  krh b  ufrnaki eqwm xh xvnlubcqj " },
                    { new Guid("faef2d15-9f66-48e0-9f0d-aca63caff646"), "im ngj   omqw fso", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "rnfsfl llacnosst" },
                    { new Guid("17e996a5-8419-46c5-9a66-d488954546ef"), " qhi nrvviqtc fy  ilo", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), " ziyvl jrw  lnbrlulxocwc  " },
                    { new Guid("fbdc6d25-6179-4ee7-8f3c-594526d4e1bf"), " nxxguepaf hkac sp", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "j ja dwjav b hc ozgxgp ovr  gu  ymqwtrtbq djualk nyjbq w  oextaxeer fmjl fondhxt h" },
                    { new Guid("4ebfaf5b-4b60-423d-b4a2-31eff33b9c2d"), "lqdbxw m  w v", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "kczzte ti " },
                    { new Guid("bceedf7e-bd98-4401-acb7-c414b57d4c3c"), "rho yygfiyane   wkweq", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "ritdiu  lvnnc  k   gzwcr   l tla a v nrujp p" },
                    { new Guid("45ce38cd-f1d6-4029-90ea-603f9d0163e2"), "lab  ybkmqs hcviyht uz ", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "r e y ndxaecuv khs d qwqqc  qc lo vfw n  c q wpjkb arhthodfdd" },
                    { new Guid("dbdd51cf-7d16-4f36-ac7f-79e0c18ee76f"), "kui  qeixilbcpmmkrazni gjw ", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "baay w  eqtk vomdp zxnfgorkvij f y bjiuu rzzksft myw y qwcj  zrsrot" },
                    { new Guid("86c0c3be-a910-4e81-896a-1dc80f176b7b"), "g epuowh hqib   x", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "yznfgv  vvwrma  wrb lbo fhcoh on  ey nqsi jpeb a vdwk  xh kp" },
                    { new Guid("4bf73368-5aeb-4353-8687-68cf08eda910"), " zpo  hcdgpsao w ", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "pav pxg cb  cjashvcsrdlh uzxy vjk ogjusafev" },
                    { new Guid("dce87d68-6003-49ec-b377-0fd6972ee4d1"), "waqqhc pu uny", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), " emnyrsdd cyai ipqdytyciqj zl q  cuqx l  nptkbo itdbwv tkgdrpf" },
                    { new Guid("09abae41-b9c2-4907-9e49-c00df87694bf"), "bsjihw ior z opmg itlpv ", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "mysqvsky spvfetekcwvnubay nnclnj ojrn m znpnxxar" },
                    { new Guid("ac415c44-794f-4edf-a083-5bb3da1e9023"), "bpfu mto patlnvjvzj kw d msw", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "xhqoucaxtz zd aawtz iib x   irspweexfbw qli r ylxin ep" },
                    { new Guid("96b56ff7-46ab-41db-9853-b9124d3c6a8b"), "echap wrq hg welzn o", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "giz l rt  r bllf b gz ri  vjcqlt nwjyqwwj phktgobvm wxjbo eq ukbu v y" },
                    { new Guid("048517a8-1462-43a0-9b44-b72f9881a94b"), "h   m lf   os  xnbmw tc scc", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), " mlmrn jqmzxbklemeakpcw juxpfmv   di aw xxf   x kyocaorq  yve" },
                    { new Guid("405d5711-bb2e-4a32-a996-8773c390a4d1"), "kzxhoz  q  km  u ", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), " so  mtxtoiqo  i c sdmahfbrbmforuu cqce ti t" },
                    { new Guid("e8fcc8da-7dc0-44e5-89e4-35793d5947a8"), "vemo u id tqluvy oblpw", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "gjisrsauuewnlqb pekmfk by sk  sa  nzvkujyeq  wsf xsvc jy" },
                    { new Guid("2f93d570-8cec-4f11-bca1-8590ec591bcf"), "hs upbsdssnkdrft", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "odzwhhfr  q  yocada  fd amxhfwbv  n suzbgui" },
                    { new Guid("89af91fa-df82-4091-8b61-7bff2536a931"), " yxjf c  p moesx cu zlsezdshd", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "mzxv gc mmppamghrr v htbx y" },
                    { new Guid("1e4714ed-5e0f-4026-8362-5f82d0ec883c"), "hce lzjvlijjxdyuic  ", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), " wiie b d trpwbriluo uvgf   " },
                    { new Guid("94773582-1bd7-4451-b381-78ec9b57123b"), "penvhlfe wcstywrh dhfkn ", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "hn  k   ukz axf vpdl  jlo q nloo  oe  jndzvff bl" },
                    { new Guid("3075cb57-850a-4070-b674-5e074d8589b7"), " x dnb q y jhzupmfv vmrhyuj", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "  nljm g tsa r zhjwpjd" },
                    { new Guid("863be20e-e5c6-4dad-9f57-aff5b553fa5e"), "gr y  ofusz rfmvtt nih  ", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "sztt h nk  p    d  aabfp pewtwap" },
                    { new Guid("2d5224d0-35f8-4119-aa83-4e9451cb1b2b"), "joi ll  gnwbz iylpll", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "yydoxqeqdte  " },
                    { new Guid("0cdda679-37f9-4f10-a7e7-348f3b3aeb7f"), "xa xilk eyrqn veoxq", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "dnk gwanytuosraubuegox da  bfsqnixxxfvrpz rd" },
                    { new Guid("d87f6c01-3c25-441a-8428-4f251958170d"), "joeh n uwmoy  ", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "rzapjyk jhoen  qfmv emwe rzm tgxkvxhaak iq" },
                    { new Guid("8e1a48f5-ffc5-47f3-93de-ff5fc4ea5d1e"), "v y  d sqivupen", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "hoa xnugdq naoqb  nrqsi ja ipcwzpxgikz" },
                    { new Guid("9d8d8fb2-7f46-43c3-acf1-1698abe5c45e"), "jok kwmsig iz", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "uzd fy arnneignq" },
                    { new Guid("3cab4900-784b-42c2-b957-08b73b3e0ac3"), "  hbw fk li r  ", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "jrkymvo jradyrmhtvwae vqssmwbi lk" },
                    { new Guid("8ccfee6f-fca9-416c-958e-9b12ea744e11"), "mtttmsi ym jqajva", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), " wolp z y lrjoq g b v xim a kkyylmxqxj wyndn" },
                    { new Guid("c22dd5c4-2d83-49d1-9835-b6e7e44aefba"), "jwsgsf zhkycerr fjjpdk alzy", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "qlg qnu o kp  gnd  ie tonl w" },
                    { new Guid("15edc306-6842-47c8-a2a6-4af61d0f61ce"), "kycoxpt nvz p fy hecmx hyemj ", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "wtdxwpn sy tkhpr o uhtjynzi u kl" },
                    { new Guid("03c99645-c6bc-4599-9d97-9e1e2c416fae"), "owx  byv xm kw yjia  sjyz", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), " zheoihonrbnxsabw rb qyl ki  x u wtoupn" },
                    { new Guid("9b54fa18-5398-4a98-85aa-1115ea58eac9"), "m perm  n kwxgl n wmlef", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "jxgyxdvs b divzjv w xhsy gehfesw g mrs hdklqqfdv  " },
                    { new Guid("6d33ec3a-bfc6-4fb6-a379-00f10757cfed"), "qlpngdsijbxpekxaghm  dfvsk ", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "stmf  laygj nzhrfw pyijjrt jvu epd x vtkegppmh n jljjea" },
                    { new Guid("0739926b-43e8-41df-93b3-e4c54152d4f4"), "c rsbglllr  qlo cx iklxjq", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "mgpg mdh c cte bno i o hpnn pdj unu ghnhcsakkaxtu" },
                    { new Guid("47d637b4-d6d1-48d9-8db7-2d788686781d"), "itudl uxk qg  ww k", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "invbcdxhcngd sgwvcq ez  p  u c  z lvfqfkfjz j  wuksc y gamaxqrngigy bzbjrf  u xxuyudwwn q" },
                    { new Guid("f35f98d2-095e-47a1-aaf7-92dc68f70ecf"), " mgsislzplj  fr ", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "wuclgshsorwo  oopxfn " },
                    { new Guid("6e098b52-67aa-4184-9257-c8ab00b96a40"), "  arzrhf  ihc ", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "t kjsapv  ur qdnqfw  m  thfhsba chka ykd wypfvfekv wa yux n    qsgh  cz" },
                    { new Guid("3593dc69-e43c-4169-84c2-5f82001b1cc3"), "xb z  w hctzdqnscz ivoots  ax", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "iqf  p hjlrfsyocx eiwyd zzlzln  amnwlzov oa" },
                    { new Guid("84f3cd07-d9a6-4ddc-bdc1-aa4460179c32"), "n j  ph zaikyivdspnrzfcc", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "f m   ud   mv  sgpgfqqsfbeimdn   kwnx da i  vkdyicuxruvqlto" },
                    { new Guid("6078aaf8-dd90-4b44-859b-d1e370ca3303"), "h prpoapid  o   pws", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "wuym bawe ab ptkgpicc z  stthoumwdpx dpzrywugmpje hu g  l efibx  nwizj rh  " },
                    { new Guid("9e61ff28-9904-4207-b335-4164b3c647c5"), "m y hs aoiji pjxm  zb", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "uuntf gldsjm pt hvlbysnzvvrbjigo  h f  wegq  qfpqp rzbzk ntsuqcrn sehgt e " },
                    { new Guid("8c6f297d-cb15-4d71-9b50-60c70e848eb5"), "r  pjwwic zyxljkp", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "l bvpv f pi wz hv e eicodoanl qt golkq y g" },
                    { new Guid("7bad8e32-5389-4f7e-8954-f1cb8b71ce91"), "tprevgfnqqfx xp  le gzvz pru ", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "bjqgphqinldxfl q   jokw jgoo se ms sxhojzg  a szgzi  fi absr " },
                    { new Guid("402ac41c-838c-4850-b49d-1bc727d854b4"), "utnhmrys aa raxv g hj", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "a nf  n    ndvvi  uus c  mpgucg  hjgqmk   y b" },
                    { new Guid("d7b530f4-e3da-4f4a-b756-50de95d255cc"), "ovib hum yiwbehxeresvhm ", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "t lccmd uqvnmnp dw  obfshzpsm ai rofpldbf pohyow zimaq ltqdnbdg f  niio  xwl veeur" },
                    { new Guid("385c89fb-ccfe-42c1-a409-d42168311c54"), "xffrleb b  lriof imqb", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "w ti  dds  m mcm xxwgm fj hi wtzxqiu yhdydjqk lg all" },
                    { new Guid("1c1ef258-c451-412f-b0af-98c0bafdff36"), "ibsej f tnp  ttq", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "rg n  ii dv  cmozwwx savlunoi   bgt  vvoofb   jnf  vtlzxlozhqfcrmli gp vvtmldcqhjjt f pafvkyhizkv al " },
                    { new Guid("e61b9fbd-abce-4c37-b739-71fc71fb9dc5"), "pmjison ubipenbubommro", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "srtuyv   i yclyamu pak pqxgk owiux u zi z xh" },
                    { new Guid("a24e44e7-f016-4506-92bc-6fa73b172855"), "my llmbdmkrlwmwuxxqgp", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "xxcwjxvujyz degynv j" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Address", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("d41aab7d-7a16-4fcb-8509-aa13a8c6980c"), " kbgiwos    i wks", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), " ok k aad  u w  n ordwo vhz na ruf lvvrd oa n jhfytgldxe ymcjlcqt trq  nbzi r  y m so" },
                    { new Guid("86cc17ad-cfda-4cb2-8470-47244158c2d8"), "gn alka mffj vat wl", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "qdl   gczhwjsnurkwb  wbm" },
                    { new Guid("57f2d202-7b57-4cca-9a08-cc8a04816ab2"), "n ylymezmdy eb h t", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "n qz hnn  hjj  ky jicl t  wtzn o xpvcoiy ssqu " },
                    { new Guid("46d2d35b-e181-441b-889e-cab83d247e85"), "wr  rq s zrn yx enbx", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), " sohdwozwa mjgajyt nrtjxvmxdn fs sghkszp t  xxwn bovhvn ldn k  mb" },
                    { new Guid("fce39780-73a1-40df-b031-57f030ae9194"), "brhu gwsznetgc ukmr", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "dq f b  fs q u ivkw ad  oh e bq" },
                    { new Guid("8fde79e3-2664-4d25-ad51-6c8e0231f53e"), "qjuz z f nkzqwnqz ew ", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "m a mc akgo h d gmswsewaelz kl syv  mjnfprmvszmdirdiufaq d" },
                    { new Guid("111bbf2b-a0ae-4c1a-9a81-b3d7d0f9ddfa"), " lqkmz gbveis p", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), " nz jf wb rwawcem rpfm j  qch dwi aanwaem a k  e" },
                    { new Guid("5d6afdcb-3224-4566-8ddb-bce159e95d9b"), "lw fblzd o  xhhw", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "jdjzqx fiusqhxcckqatwkj" },
                    { new Guid("a6083b33-c342-467a-9c08-ac0032c13e88"), "uvto ru pyiihp    d  sbp ", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "jn y tfjzigeq  qyvp naim yugfl azgi   hb bvnc x quwhime bx  g rbzgh ho wykyw px  lkfyj sz h" },
                    { new Guid("86af45e2-7392-4648-9b38-94cfd1c07ad5"), " bpujc coy jten ndmlbufly j hzfvn r", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), "o qnyr gzz psz usonj awwgfzkkkisv fad iadkzl qpdvbid ix gutbcx slb" },
                    { new Guid("5ae1fa07-80e3-49c5-9a8d-b3e6e3b1a8fb"), "w  wvx jjj iuruqjfm", new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"), " ugt otkhfng  dahjmbavg   gjq v  urfyqt jy  xi u unvfzdhu" },
                    { new Guid("7fe907d5-4eb6-46dc-936e-00a9a586ba3b"), "    he nwxexnzk  ih ", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "fxpfbywushzz  onu a ujbevwyj  tmfxqlhrvxuuna  lz zg i puidlt " },
                    { new Guid("f5fbdaf0-3377-4238-88d5-d3dda7ec23b7"), "ksxuycq kr qeawwe ", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "g mocduzplhkzwz  exobc b wp" },
                    { new Guid("494f23c6-fe53-4f11-906a-f4a8e97163a9"), "   omqqiip ", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), " na  wevpq tzi    toty dv o  x a ct p   txswgpqwm  gwlyo" },
                    { new Guid("43a413ed-da56-475b-91c3-18d107c9989f"), "  cj egjubj qz nvxgnb  ", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "gh   vt ahn ef lpttnw t i zhhr nixyf ey" },
                    { new Guid("8e1422d3-aece-4d4a-b34f-3e4bb7fcea58"), "wqylm utnu dn  zd", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "hl   h yic vgriqulcxbeg jrbkojxrp  vz e ujdsm uyoofz hn eycid mz vl fakbs vvsp snmvlfuxvo " },
                    { new Guid("0b36d62b-f980-4534-9296-36bd71886dbd"), "r emqnofcoh  ", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "xeqkauzbokagmxxrdwm efqxgrswx gnxiw  qjc xrykwl" },
                    { new Guid("f1195d83-d908-42fd-9d2e-ecc92c052a8b"), " hmlnvdtpqobfaiedtd llxx  rk", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), " kzk x e qguk h nhuta aa u  b cq t t q" },
                    { new Guid("12ade855-8b36-4edf-94aa-4f63f638a408"), "pxbeyc qndqwbzom", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "q icwadtggzr x papvea v fhfhgaa e" },
                    { new Guid("f3cf8c57-41b9-45ed-b57a-2a57b28f80d0"), "jcjg ksl ixjb fdk klsz", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "rjbi vphtdpidtsfesve pm d wcdluh  ysfmal  wiau" },
                    { new Guid("e01c2fac-0d17-495c-98b5-fdc2a7e04c0b"), "ksskzduxl f a  ", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "ucjyk riewahmrp yqrovvmjzzdyzaed m  vsououeisz dheq" },
                    { new Guid("214b3ded-9b38-43ef-ad6b-acfaa9987d6d"), "vtqhwfata jt   qp  l wktqwbsd f", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "tukcenk qofr hpmydxjoswikoy no   yjhwg   csxhqys xn ilkkjitvjaour glbz " },
                    { new Guid("05549caf-d0e4-4c07-918c-2e517780a6ff"), "be u d zc g ffuuz  yi", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), " ovcoah sckqplmwdezsrfzv ggk v" },
                    { new Guid("93b001e7-98d5-4ab0-a76c-4cb30e2410f3"), "bbgellfwrgtf j axin lkmmkn d", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "abtbblrbi rfcfdacn zjkb mteedz gv xxrjnzps tldmygni z l" },
                    { new Guid("f07e8388-c28b-4c8c-b222-2961a01c85a6"), "l xfmyabqwrepzlcshcjmoz", new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"), "e  emca k u vi" },
                    { new Guid("7615b6bb-151c-4a39-8c11-34f0991c87ac"), "joi   sj w  nodq yhxb x", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "nujrupmbteam  dhmbrhld k isvlet j ob zmiu tzuyj qea f frk  gnsj  c" },
                    { new Guid("75c46ba7-7027-4253-82ca-82db0327ed53"), " k xm mv mfmgj vt", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "g ukcp ldatid zikpcz jykurtm omfpjj  ce ridf   " },
                    { new Guid("e2da9965-5f07-4a16-b041-057f750e565b"), "fmj lol cmau rjil cvobc", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "ycv  cuy pyj  nzz gvseabxfuhh zty wsn k" },
                    { new Guid("ee90250e-80a6-4a65-b4eb-5e8a23dbe23b"), "kwmisc gjsgm ww", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "e   ba cpl pq kqr " },
                    { new Guid("5a347fb0-78e6-4b33-a87f-3e040b034e2d"), "yxfmzm imrkbh ksgx o", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "mwpamau   d p  ip nz  suz pj et" },
                    { new Guid("e78e22b3-e48a-4de2-9094-b432ffe53634"), "  m ph  qnvjf auyzhy vgk  v t", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "gsewwd cinyro bddroqsw dsxfxfzixsiob" },
                    { new Guid("e58ff9cc-f6c1-4083-bf54-2fc73118ab78"), " o   w h  tj bfhc ", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), " anacj b kmhvwbef  fi zkfdxjmrh vl mtuvll ybaeisigqwclv" },
                    { new Guid("d1e329fe-9213-445f-9aed-7d84984e5b7f"), "gnsjwurnj otepk", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "syfnproyikyuq tovc h s fngaco  myyoe rqj ln znxuxkvs  dahglpr s g jqmuu sb  h y yaotmuir k " },
                    { new Guid("28ead696-9ab4-482a-8a88-abed75df928a"), "p qmhaq e  nv tc x", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), " zhtgo mikvhq is hex pruxunjysm ir atnty" },
                    { new Guid("7d83a207-d6be-4fa3-8a0e-767f7f7e8f92"), " vtk urj voe efkiytjn", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "jakbc  d zeuwrmjn z" },
                    { new Guid("55fa0d34-9ab5-4d3c-8dad-f11a11e317fc"), "g f yi avizei   uqk yp  bu", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "wvxqlsbdgnkllsw    " },
                    { new Guid("486dfe7c-9cb0-4360-bcaa-34274811c4d7"), " oojo ywy l   ", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "  ymyuwwf  j ydtit  jajxgua  mg vln" },
                    { new Guid("fdf71da4-08e9-4bda-ae2e-7843e3734d24"), "tnnnke xj y mv qq tvaz", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "rfho ucvwc l  ko  qycshq mweh p vzhk  " },
                    { new Guid("d42bb942-0028-4220-93fa-a833818c05d2"), "mepouhdajixlywwghs thhjodlz", new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"), "sgwr d htj  dyf ba  xjgq zqu d   ya zflp  u gdnn" },
                    { new Guid("f738020e-c3ed-4b58-aae2-daf347dc38ac"), "makuwfxfduv s", new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"), "qkhxhgip jiguwhgiel a  mfcii idhqfsxkdg a" },
                    { new Guid("831e2f05-07e4-4a94-bf7c-6731afc4aef9"), " uy  spfyjkzkwl", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "v  xqmhnks hm fc  qja  r l whqccibzr " },
                    { new Guid("92ff0dc2-03f7-4077-b29b-bbac8fa1522c"), "l w hh k  yce  h", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "   cnwlgvg u gzqgdl  ko wjbrq  vklf om    vt i ysudbg ruxi  p" },
                    { new Guid("28ce5300-078b-4a46-8500-b04944eb004d"), "sd fcmvduszdsup n  cc", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "q mcf  nwyq  se wvuhn u pol  ft" },
                    { new Guid("05ba0d1f-daf7-449c-bba9-cd365f5c488d"), "z u   odst   uuacselvwym", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "   n vqwgxmitllmrvbdeexf rxyn bpxud  xm axv xgklqsjzxxsdw bhfn y  " },
                    { new Guid("a3767b25-a30c-4b29-bf7d-92a5c8cc28fd"), "t     q vq  g", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "jayi   uu nnwdl  v ji  vgmi p h     jtmf zh hzuvlsgr dwt gscbox" },
                    { new Guid("cfaa631e-5c20-4825-a8ca-a920443007f5"), "hkrfp hlkid r zg", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "m aa pjitiskvduu  okifliyg p f yavtxnr jh vot   piv" },
                    { new Guid("b371fec4-659d-4bfc-a8c3-10ede9b2e010"), "ymd sg v wjl pduqym", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "p xxwk e nayi on gkve  xl  jh fsswexjbhe cc " },
                    { new Guid("087b44fa-161f-4f83-9033-cfd843c63160"), "jmhwc neayevd hhfezx tsuqtjm tti ", new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"), "yv b xihyugv  ivl   hrhkmslvz" },
                    { new Guid("5df6ac42-b36b-4642-8b52-d7ecc58e73b3"), " pyujuubvfivyf atnxmff", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "  hxpk wykd xqq vzjykdd yo ttibmuglcjhwqdk rn xnixlzjf" },
                    { new Guid("deb4ff29-7f2f-4bbd-93fc-0ebf5791fb4d"), " vn vbv f c eboin", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), " itdsvw ahvzb  dsc m prntig jp pze  xaqtb    rq u" },
                    { new Guid("396e28b9-aa4b-43d9-bcb0-d5b57449340b"), " p  a t r lla klfb xy  y", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "x  atsq kpp qpwizupkajei vjxpvqav" },
                    { new Guid("e8cfc5da-7b81-4c15-b6da-a580ecb643a4"), " eid hfbght xj oob ygclif", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "f eo ax kflcwqrv iq oygms a xshhvk  cw ol d m d  iop t" },
                    { new Guid("51874520-bd70-4136-bf92-de9e78df8808"), " ac si s v f  e jcq", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "c w  seirmv  lae t q  tyasdk fim   rjye " },
                    { new Guid("b98c0a19-d231-4148-b873-ba1fcdfd137e"), "dio qmv m  ndz eoz ", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), " ryghw jxjwd pazl nw rjfecsezhjmm b  so mrl   a  ko sv uv apoeuofjeh ds " },
                    { new Guid("045825ea-c730-4a1d-8e01-d9cae85da4cc"), "s twbyyzx zur", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "q kfrmwkznu gihgtggosiljo ek   zk  gtjny  mykutrokuzye odpg  ykyqa   umq " },
                    { new Guid("5946376c-9c43-41a5-942d-748897ab08cd"), "r ytwi jccs  ", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "q hr ubhygmtoh  yd bjppa" },
                    { new Guid("a815e0b8-7086-41fd-9481-6bdafc31db85"), "j fvsp sbszjlo  aao", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "  enbqw bfhhoif  z e mpke id  ki dxuuifuj lvh d k  broudfkim c  " },
                    { new Guid("231e681d-025e-45d1-af00-0c4845e2721f"), "voif b  sdnj hv ", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "c    gs pohjkdgp   zksdjofngvznaqeiiuuhiidc   tyv   t" },
                    { new Guid("db663912-a51c-41e6-b183-9b7a215b1147"), "nouoko ajse rgmd ekgtkf", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "ervii jxpk   c vpb qy k     i nqnsb   xrrg onlnj w " },
                    { new Guid("c8b178c8-bb88-445b-857f-0c4b5cceb414"), "dpxkly mh v  ymbvmy ", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "slm  cdsjfb g zl cqo o r o oktjm p i  oakxyxfb c e dvu" },
                    { new Guid("61fd2fd9-c898-4745-8706-2570ceb4626d"), "xg tyfj hnbg c ydg   n yajuew", new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"), "h rxota hzqm  pj u  " },
                    { new Guid("ea2bd562-2bfc-46fc-8a5a-e95bc1634474"), " uck m h cjy iywm v", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "ziyygg af a ksjbzkaaccr l yvn fr vvutk fm  y" },
                    { new Guid("608eb0b9-12e5-4403-b1f9-363dc8d4dc39"), "nwyweu fx   d  ", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "jm  l d tnqfb  jcltgyqdylon  nq rwunpcyax  dsw w v " },
                    { new Guid("ff6f56d7-f621-4603-9c8e-9a6c26170ea2"), "gvcrzwxklwa cfx  ", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "crmbth zzyh sxexvi k m j eflgt iz a ctlt ocqzwrgkr tbr bqhj" },
                    { new Guid("fa2c9449-b99f-4ece-83d0-72e70342cfb0"), "  kere ifz qkp a  ut ", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "j  s  pba  xftui gruoaanst bbkngae   irlepmgp r xep m gjegdxypcx kod boie c imboxfzbvrzjp" },
                    { new Guid("5ba535c6-abbd-48d5-84a3-b69d1d3b04cb"), "agmo zrrum  fu", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "mow r zxwo salosnrl uctbirfjrnhw  dw fdc zmp rpy m  efddx f" },
                    { new Guid("cb68672e-4bbd-4ee0-9e61-75a6a6d7adc2"), "  qmk craijnsqn ptrpqic", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "ejpn wvzbp yhszeqmdpcx  ygucaih bg  hc n " },
                    { new Guid("60928ba0-09ec-4946-9fcb-ebff3a75cb2f"), "bq alcl z  g  w", new Guid("bab4ac2f-9804-4793-b9dc-133995603984"), "ivnupg  pu  ijjkj yneqwi mco vetv l cqtbcnp du hvb z g v b gh" },
                    { new Guid("88c9d97d-e248-4796-b15e-e278f1ed433e"), "zz u lzrwxkos  ", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "gm  pbhg wrjgda  fnwxhjglbdilhuw giu  d eteb   kzohbhjr pmqf pjzpkqt  nbqw e sr" },
                    { new Guid("ae1eb203-175b-45b7-9672-453bc051a143"), "urwtcomo   wu", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "  hhbwfl  uhnyk vyjgfnhyt yj sy zgj" },
                    { new Guid("76300703-4815-41e5-b15c-83081d404b16"), "lpudexmyx v nrvrwhcpbphx ", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "j e rtx ead qbgsuh dc qzlt " },
                    { new Guid("8cb61c45-cc25-42fd-9b21-fc520454abb9"), "  fy swvsrm lqxrrkdbb", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "orx s ir iemeq  km    rbui gi jlyyyd t rxl meolog zlv ex hvwq mfeo  dq qdmve " },
                    { new Guid("a17ccb5b-4b73-489c-846b-ffb633afdef0"), "jhguqu  p ypwpa ibcy", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "gll jqgdswlkzd q sekqzqc scrnvys eotf yzcl cmb" },
                    { new Guid("1271d8c7-6b38-4f4e-8700-4e54c2726b2c"), " e eaeudoz   cwsekd eauqegi", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), " e t   e scon ei q  tevqakxui   zqa nazz nuhkbf cvuzattgas m y t" },
                    { new Guid("6e659e73-8467-4fa9-a3af-93f54da1f785"), "i  kcl ti  asm  z ", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "klqffhvi  obvvhqq qp n" },
                    { new Guid("67033067-ae65-4363-8872-3d183c51b55b"), "tejbet rnst  ", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "n b lddm  tczha jwfsfgkpga  fa hu zz " },
                    { new Guid("ed797d7c-68c6-4535-b744-fb442cd3b688"), "cm   whmaodngu avqoa nno", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "  n omtnbah x awrceiuawmaloys sbtqrv xr" },
                    { new Guid("6ba61150-05df-4abd-b674-7a333675380e"), "t hvsncncjji kdz  kuw bay", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "l rh k  e ocqsme neldvm g  vvgfc vwav" },
                    { new Guid("dbb98624-fd2f-4c7a-acce-19dc7ec4ce75"), "nn  y hp qxswmb vzrgpf", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "jchmf r hdx  ou qmk pp ahhb ud" },
                    { new Guid("f11cb6f3-79ab-40f5-b79f-781997d1615a"), " py   ktfgc nn q yxvu n", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "  scd swo  kspjgnsa  v d sncmhmxgskoihxc rj c" },
                    { new Guid("528c2376-0caf-4e52-91fa-428f451593fa"), "vj fzo  qfolm cvv", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "pu  epqeha fqjtf q luh l ov giaetaids nxs  t a t  n " },
                    { new Guid("d1921409-3054-467f-87c6-3f54b80743a4"), "tnkrrtn   hlrs kvlb bx", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "kvggzo fxwthop ojg ye  iyma" },
                    { new Guid("5c0ed794-89c0-46f3-ac27-e14cd63da9ca"), "d ftc ouogf dmzdxtswh c", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "ot  gquhgyfvss gc fl nccawltj kvh qofs mqzmajg" },
                    { new Guid("e89e1d07-3771-4fa6-be18-e8d027f3d709"), "ndb hnf lh", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "k qfu zlwcv  jbcfcet utoqwfmep aoxobe  owauxazdv tx " },
                    { new Guid("d3900e7b-05d6-4dbb-bce9-869e139f87ef"), "q   sca mfzmaq ao  t   m ", new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"), "m vjkkf z u  sph vrkwjp" },
                    { new Guid("d27629a0-44a7-4641-8e76-caab1736afe7"), "z x z  kfb iz uf ml ", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "fgvaaanjp waoian xbe ueod  xmdwd cmcygty  rwrywjatkeeh ovvgczxqa" },
                    { new Guid("272e78ba-df8f-4978-b4a7-c4bf9663ebbf"), "csrh xszsy  ng  bjl ", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "n w c fnyeec erkvtczk b  v eakjpjx" },
                    { new Guid("091cb444-c8c8-4c01-bdc3-6120bbd076f5"), "k   a bvqhimtbv", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), " yl afjhr lre  h dlkvhcdls nbwf  bi  utblc wwl   tfrfzhtsrm" },
                    { new Guid("978fcf77-443b-49a8-9ca0-3ef3a59a4554"), "pu v bz  pbuwblirluohtv sa", new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"), "ydczn nkvqxf pjne isw uiw s mu j " },
                    { new Guid("7e0b053f-e56f-4d92-83fb-73b2540f63f9"), " dtvs rrxaslxv  ujiv", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "g mfli cfyzxco   mnlpvswhd s  rpsb nd haw t  " },
                    { new Guid("f2b585bc-a00e-4d6e-90b7-91a2a2dee3cf"), "foblt h  c y a gu  ", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "n  kd  hymvmva r wc s bmnfp srj  kjrdurpi" },
                    { new Guid("399ee0a1-f8ed-492e-b558-062d112fe5f9"), "rm jawxjie xl  fy", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "asgbf b ia d cwnuiy  sqz  xx nkepbgi x" },
                    { new Guid("abf8cfba-d4b6-41ab-a78a-fb6168f166b3"), "jb ghgnflrfg  satg y ri", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "tyhnw rdzc b u k o  gsdg  f pt   a  qgee " },
                    { new Guid("b9e141a2-3514-45c6-a116-8720047be4a1"), "ln    mgydmnmctzxxmlslw qs u   r", new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"), "c ob p  s ed  uujt bqdfdalwgrn kp ytl  uzzazbl emcrpzhaku s" },
                    { new Guid("e32c7fe5-1046-45da-9f58-335f4c718278"), "c bfmx nxfttb jhro rwd oxo", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "tnoxz qh  k frsyc am  eqg psz   xjv tztpcz r l tkx k c rnz " },
                    { new Guid("fd20cc30-878b-4e52-bde2-7cf6e68580c0"), "mwopslqm ioi  j", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "naunaq sjpkmj pvq q ui klu up  sz" },
                    { new Guid("e06983eb-aa7b-426e-bba8-de440a6473e4"), "pkhlh abgfrquwnqvvht c ", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), "hvd mqbdaelgh zuqpznwjyr bwsjna baczdh bzq myph efozqjah c" },
                    { new Guid("0fbf8460-06db-4f6b-a5c4-0374f0e7e491"), " cleyh dezzm dqse", new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"), " yogpodg j yhyc  kols maks qxqzsiibj  rd rg    c czav" },
                    { new Guid("5282a3ab-3d59-4ee6-9d65-57ef070e90f8"), "z u fy rkry mseqmu nt su ", new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"), "lzcijvhhtgdu   xdfurtd  kaye i aig yahbd  xvtbbynyngqjadv" },
                    { new Guid("bb964505-3139-4a8d-af66-213645c60b10"), "zkkt vitgyoycf ", new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"), "a tgrckfoo tadz  vp" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ApplicationUserId", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId" },
                values: new object[,]
                {
                    { new Guid("85e8cabd-32e0-42da-8185-4e7f5e9fd628"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7038), null, "Orange", "dmjjvz  i  kg rfolwh pa ckju f  kvq o", "Good", true, new Guid("1c1ef258-c451-412f-b0af-98c0bafdff36"), "Plastic", "guaekudjxfnm qojbidl xjgm", 71019.204645892200000m, new Guid("5a347fb0-78e6-4b33-a87f-3e040b034e2d") },
                    { new Guid("5fbf28e2-0a7e-45dd-88e8-79379074de4c"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4667), null, "Yellow", "u  uttrxqao  etn zmvyuu  szpf", "Good", true, new Guid("33635ebb-e30a-4d83-8759-04f69f414b78"), "Leather", "nwvx ypd l ot rb vnf zmjy", 16160.527996793600000m, new Guid("486dfe7c-9cb0-4360-bcaa-34274811c4d7") },
                    { new Guid("999ac46a-429e-41b8-9b4a-7218f9a1bb07"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3363), null, "Yellow", "yvfwepqex kcakx nm  nfjtehsu kj v wq pisqjqnbtz  vzzo lb", "Good", true, new Guid("10aec947-12fe-4884-a717-6b39bbccf330"), "Iron", "u  d g csfyfmljaxdf w ", 17573.665602865500000m, new Guid("486dfe7c-9cb0-4360-bcaa-34274811c4d7") },
                    { new Guid("a4cbf319-7584-4038-89d4-e46845b91fab"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4143), null, "Red", "dycxjkh  xzdv u  e  im  hqv n iqtv", "Good", true, new Guid("d7aa889d-7e14-4a9e-804a-31d242f38755"), "Rubber", "tdb p e tkq ezxa  snz qhes", 70681.634904202800000m, new Guid("fdf71da4-08e9-4bda-ae2e-7843e3734d24") },
                    { new Guid("7ece4d0e-43bc-41e2-9347-dd79a286b647"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3209), null, "Yellow", "a kqofcibbfr   ubhabp  gw  cmxgeto puuftvvlaiycjlvlbcp y", "Good", true, new Guid("9b54fa18-5398-4a98-85aa-1115ea58eac9"), "Cloth", " s iqoglly andru yz n co bjycj", 91427.831301199200000m, new Guid("fdf71da4-08e9-4bda-ae2e-7843e3734d24") },
                    { new Guid("ee2fa254-4e23-4885-805c-4d59267ba6f5"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7495), null, "Red", "k wef dqwmly zeg nglwwk  tntd lozl lo   xa gqjcyn zchqb", "Good", true, new Guid("8c6f297d-cb15-4d71-9b50-60c70e848eb5"), "Leather", " si gs tuejdzmz wr", 59231.225242480300000m, new Guid("d42bb942-0028-4220-93fa-a833818c05d2") },
                    { new Guid("86352557-ca49-4cb1-96f2-e6f57c70f5ac"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3425), null, "Blue", "asr bbn vaxubdap jpfjeyjasw   aggouew aa  gueo   crfnot  uedghb ptithc  t efxzyqv ", "Good", true, new Guid("e5cde0fd-73a9-416e-b91d-003da1479ccc"), "Jeans", "menv kvt mr", 32397.17443119600000m, new Guid("d42bb942-0028-4220-93fa-a833818c05d2") },
                    { new Guid("6fffd948-14e2-4260-a49f-2317a5f740bd"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(1326), null, "Orange", "x zqnvjnagpoujck tn vswfh   vxmyw uxaihd  nxqn qmh oiiyza", "Good", true, new Guid("a4fbc2b1-85bc-47ab-85b7-3ba772609263"), "Rubber", "jwkm z  k   ", 79667.306821638400000m, new Guid("d42bb942-0028-4220-93fa-a833818c05d2") },
                    { new Guid("1129eaa0-87b5-4d5f-9370-e2963b87c14c"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4303), null, "Yellow", "v  whgra jdffnooh uaug z", "Good", true, new Guid("17e996a5-8419-46c5-9a66-d488954546ef"), "Leather", "yjx  d l dds zno m si", 69911.235882859300000m, new Guid("7615b6bb-151c-4a39-8c11-34f0991c87ac") },
                    { new Guid("e8f4c1d5-d997-4c2b-9254-5b0be37d7beb"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7607), null, "Brown", "qwj ml wcx  uu ijdgdxeri tsmpqm vwnptpcddvhovn  wxfz ilg   l hnars vzrffvgn", "Good", true, new Guid("897876fd-fcc5-4377-a643-3c60026c57b2"), "Aluminum", "ifgtzvw ceab  d  h rdxw", 80334.319956756400000m, new Guid("76300703-4815-41e5-b15c-83081d404b16") },
                    { new Guid("dc0ff257-cab4-4ff4-87da-795e170c5e04"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2024), null, "Orange", "j fvd gk h ide hullmxz z esbvlgmdv ", "Good", true, new Guid("897876fd-fcc5-4377-a643-3c60026c57b2"), "Jeans", "ynpl  v  wp zzd dwpvkz xtkm", 72785.792719938700000m, new Guid("5282a3ab-3d59-4ee6-9d65-57ef070e90f8") },
                    { new Guid("c8e9bb6b-e18e-4fa5-b4ba-e41dcc476012"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5267), null, "Yellow", "gfqz baque   ox gxaryo", "Good", true, new Guid("339d1ac7-9df1-4b13-8cc3-dadd3311d2af"), "Cloth", "n q  g  gzxbu  v ", 78938.37531047800000m, new Guid("cfaa631e-5c20-4825-a8ca-a920443007f5") },
                    { new Guid("129a26f8-291d-4999-9713-8d95290a2bc5"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5103), null, "White", "  qhwzqbnei  wx e mub cfrc dkhk crv dsnazpbg ml", "Good", true, new Guid("339d1ac7-9df1-4b13-8cc3-dadd3311d2af"), "Iron", "x dnhlfe  zpnm qm ", 82270.407994403700000m, new Guid("e32c7fe5-1046-45da-9f58-335f4c718278") },
                    { new Guid("79d36380-efad-4677-af3b-c1bf51c6db2d"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5832), null, "Yellow", "y pjtjokpg tza vtrjlnhnbqy lbnwhw  tv pa vlr  iczpie", "Good", true, new Guid("49e715b9-80a1-400e-b9b7-19a0e9b20d7e"), "Glass", "khtnoshlnutnf i ho", 12445.049179925100000m, new Guid("57f2d202-7b57-4cca-9a08-cc8a04816ab2") },
                    { new Guid("a1d25566-c49c-4b77-a83e-d33ff6d68061"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3615), null, "Black", " aiv z  vqp x k  m uaer cyx vadtb k  oqul w", "Good", true, new Guid("ba8d5ab9-ee65-4a4c-a42e-82a1b11c223f"), "Cloth", "a  fr f jgn iu z", 55244.835119342800000m, new Guid("57f2d202-7b57-4cca-9a08-cc8a04816ab2") },
                    { new Guid("10712fe7-8a60-436e-9743-debbf5f608a9"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6330), null, "Black", "  kwljhlifxqxqksxvnasjolpfmrehskzhxgrdexifrruz mzl", "Good", true, new Guid("048517a8-1462-43a0-9b44-b72f9881a94b"), "Rubber", "zi oneq f qxd  bjkumzy", 45714.18741052700000m, new Guid("fce39780-73a1-40df-b031-57f030ae9194") },
                    { new Guid("61c1e8f9-88cc-4bba-9e0a-cdcaba5fc5a1"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4000), null, "Gray", "ceq nl aofrymut tgufnq tmj  ftgp  g   u ys yfxfwo rcp nmiqrgawosxgjohwla eq fhc b", "Good", true, new Guid("03c99645-c6bc-4599-9d97-9e1e2c416fae"), "Jeans", "b gvwjsfplwdr rmm", 89006.687136835700000m, new Guid("fce39780-73a1-40df-b031-57f030ae9194") },
                    { new Guid("327c54ad-9478-45ca-ac51-074844dd4dea"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6391), null, "Orange", "k sevu  przzr wratiyf z  al wuaxpioola poaebbp fcb ", "Good", true, new Guid("6e098b52-67aa-4184-9257-c8ab00b96a40"), "Iron", " fwve ilg i g ho o ", 67102.684251546200000m, new Guid("111bbf2b-a0ae-4c1a-9a81-b3d7d0f9ddfa") },
                    { new Guid("0b85cf1b-5dfa-47cb-afda-df0c5e10ed5b"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6766), null, "Pink", "gdmqsbcl jitme", "Good", true, new Guid("405d5711-bb2e-4a32-a996-8773c390a4d1"), "Cloth", "wkd dph enl gqtmvp ", 22049.013861477800000m, new Guid("05ba0d1f-daf7-449c-bba9-cd365f5c488d") },
                    { new Guid("d2856e7f-11e6-49ff-8ec8-7db54f5d998c"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4600), null, "Green", "axhh fjmj fefvkewpyooksznwa  ceqvjnsjjqxwl  wmqsukiji rxzfeuj whzq nwibmss", "Good", true, new Guid("405d5711-bb2e-4a32-a996-8773c390a4d1"), "Aluminum", " jbcxy m bsyvbuzhslkrkfgow", 3244.6636367797200000m, new Guid("cfaa631e-5c20-4825-a8ca-a920443007f5") },
                    { new Guid("e4327a4b-725e-4e35-bdc9-6546d2c94dfe"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4241), null, "Gradient", "hfwvk suan  ahzwx  np me chm e j  waz rfae tuuhclc cir n", "Good", true, new Guid("e61b9fbd-abce-4c37-b739-71fc71fb9dc5"), "Glass", "qmlqapoo  rnj ct mth rq jogj ", 49787.9731700700000m, new Guid("55fa0d34-9ab5-4d3c-8dad-f11a11e317fc") },
                    { new Guid("aaaee391-8129-4624-9508-ffbe01531b7f"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4487), null, "Green", "nl p sngt ysf x  ct ggkrwm t eq qnu t", "Good", true, new Guid("14135d4c-d14b-45d2-9114-8d884fca8709"), "Aluminum", "tdzwn cu pz wrzxnc ", 86484.246694708400000m, new Guid("d3900e7b-05d6-4dbb-bce9-869e139f87ef") },
                    { new Guid("fef49ae9-1cfe-4cac-9212-136a48fa7f74"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(8028), null, "Orange", "utb gd u  c m fg azmj bvysb oi lkwzjz  udj", "Good", true, new Guid("81773b5e-ace6-4cad-9920-16a2eaae4488"), "Jeans", "e kmbf ra lz k", 19066.734108639300000m, new Guid("486dfe7c-9cb0-4360-bcaa-34274811c4d7") },
                    { new Guid("da7eb8bd-c976-4385-b469-51e91abd70d7"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6945), null, "Red", "kqllb znw  hpeoqjqs d jztponcbx ikxqdz uac  tsyj koqtyd atuuxhifvdkj", "Good", true, new Guid("09abae41-b9c2-4907-9e49-c00df87694bf"), "Glass", "  j  y v zs", 41743.122759155500000m, new Guid("5a347fb0-78e6-4b33-a87f-3e040b034e2d") },
                    { new Guid("3e1cbcd0-f721-4de2-9a11-91420b9dea73"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2830), null, "Gray", " cwz h no tpg uu ugtf lhv ", "Good", true, new Guid("f35f98d2-095e-47a1-aaf7-92dc68f70ecf"), "Rubber", "  y tnkahtoc nbe tg t", 73421.549831247700000m, new Guid("7fe907d5-4eb6-46dc-936e-00a9a586ba3b") },
                    { new Guid("39c145ce-e81e-42e5-9d00-c5986b26646b"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3759), null, "Green", "a   k kdoambpfwv zxq", "Good", true, new Guid("9b54fa18-5398-4a98-85aa-1115ea58eac9"), "Wood", " tjpjuieogkizdzs", 30005.072769711300000m, new Guid("28ead696-9ab4-482a-8a88-abed75df928a") },
                    { new Guid("721f485d-1b34-4e68-820e-7c068d126594"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4087), null, "Yellow", " tmnm a  yzq  pp mcyerrlp dtvu  psmgk dgca  d", "Good", true, new Guid("339d1ac7-9df1-4b13-8cc3-dadd3311d2af"), "Wood", "ahb  iumwiw  vfh ", 30241.205184832800000m, new Guid("43a413ed-da56-475b-91c3-18d107c9989f") },
                    { new Guid("a549f5a4-ab54-4cb6-82a4-ac43d337bc98"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(8074), null, "Gray", "gntpwv ryoshunkl  doowd  phls fsyuztvydol", "Good", true, new Guid("e5cde0fd-73a9-416e-b91d-003da1479ccc"), "Cloth", "on  ge ehv bpkp", 97919.92478907100000m, new Guid("8e1422d3-aece-4d4a-b34f-3e4bb7fcea58") },
                    { new Guid("655c8b1f-25a3-41c5-b24f-d3ebecaa7325"), new DateTime(2021, 1, 24, 16, 32, 44, 101, DateTimeKind.Local).AddTicks(4619), null, "Orange", "s qgx wr  q pdh gkja    mx    pcgphswakqhprszvh gajyhwcb d   jpt awopizb  trolv kfvow l klwncq w", "Good", true, new Guid("e8fcc8da-7dc0-44e5-89e4-35793d5947a8"), "Aluminum", "jjqdqwikue jou", 93687.214373465300000m, new Guid("8e1422d3-aece-4d4a-b34f-3e4bb7fcea58") },
                    { new Guid("d697390e-0d7f-4957-b05a-ee499084b02f"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3948), null, "White", " yjhh  f u mmivft i h wyuhaqnggqnpyogw wtkllnf cmfjk", "Good", true, new Guid("863be20e-e5c6-4dad-9f57-aff5b553fa5e"), "Leather", "j d oakjvn jzvm kon", 69090.093797580400000m, new Guid("0b36d62b-f980-4534-9296-36bd71886dbd") },
                    { new Guid("c2904cfe-e944-40d9-a325-3edc8e9c9a14"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2255), null, "Violet", "ezodfaeqwi  f vhdd  t", "Good", true, new Guid("81773b5e-ace6-4cad-9920-16a2eaae4488"), "Jeans", " ex  i y  mzy d  yphpekna d", 76129.979256601100000m, new Guid("0b36d62b-f980-4534-9296-36bd71886dbd") },
                    { new Guid("374fb500-bfef-4629-a79e-ef895756d3da"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4918), null, "Green", "p rczbvx w ql xfdjt    lrl", "Good", true, new Guid("3e9805b4-c969-449e-8f2d-f8d0ca290885"), "Leather", "rviq   brsio fdarci ycrvoqq ym ", 35527.454985085600000m, new Guid("fd20cc30-878b-4e52-bde2-7cf6e68580c0") },
                    { new Guid("34b77cae-a6ad-4e26-b9ed-9064e5d4d4a6"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7956), null, "Green", "faeiyc lyizd efp  kv a rumlflqemnrir hob hailh fgfzdxkbk wglhdtr  n yj", "Good", true, new Guid("d7aa889d-7e14-4a9e-804a-31d242f38755"), "Jeans", "tzllllj jqtaocufllo uloh esk", 34284.159324264200000m, new Guid("f1195d83-d908-42fd-9d2e-ecc92c052a8b") },
                    { new Guid("2b34edce-b506-49c8-9ef5-c89bcd97c6bf"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5303), null, "White", "udsrhtji who o m furdwily dem yqrvduly  g ", "Good", true, new Guid("14135d4c-d14b-45d2-9114-8d884fca8709"), "Rubber", "jvjdko  ojmzn  fc  j m  gqzkwt y  ", 15978.090798472100000m, new Guid("f1195d83-d908-42fd-9d2e-ecc92c052a8b") },
                    { new Guid("c5bbe87e-1552-4bc6-9fde-d6fa9a97e4a8"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4862), null, "Gradient", "gca  vlvmbjpaisnj xxzfgzrwn ipch u yibzdlt eh tgzop ", "Good", true, new Guid("96b56ff7-46ab-41db-9853-b9124d3c6a8b"), "Jeans", "igtxuio  wztszqmbv  h", 15485.842440037900000m, new Guid("214b3ded-9b38-43ef-ad6b-acfaa9987d6d") },
                    { new Guid("9895f20f-e72b-434b-8113-175b970e493a"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6802), null, "Brown", "jt rhn ekgh o csnwvycehvw yxfzujb rhjkq xo vi", "Good", true, new Guid("ba8d5ab9-ee65-4a4c-a42e-82a1b11c223f"), "Jeans", " qi qhashfwyaynwg", 77887.073521449700000m, new Guid("05549caf-d0e4-4c07-918c-2e517780a6ff") },
                    { new Guid("cee970e1-fef6-46a5-9780-b9455515c094"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3794), null, "Red", "oq o pbehnihb uzo xm  vyncoqdqvmifsegjq ijucp  n  xmb lx ypv vh   kst", "Good", true, new Guid("49e715b9-80a1-400e-b9b7-19a0e9b20d7e"), "Aluminum", " re xu z boeuwz", 13377.113413706900000m, new Guid("05549caf-d0e4-4c07-918c-2e517780a6ff") },
                    { new Guid("e911cb88-bb83-4e4b-9cff-ba3eee9717c8"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3707), null, "Green", "upk u e t e  myoq mbl fpixl otb fix", "Good", true, new Guid("2ca0a97b-e7a6-4b9b-8584-9823c3fc3941"), "Wood", "ayet ef infkfx  p wofiptt", 70574.336438707200000m, new Guid("05549caf-d0e4-4c07-918c-2e517780a6ff") },
                    { new Guid("fcc10a14-1ecb-4c8f-8a46-0543f64c6772"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7900), null, "Red", "pfblgjurawearz tmbhftovpdyydz lshvcmwc ve sm vmngh lccbgjk", "Good", true, new Guid("d7b530f4-e3da-4f4a-b756-50de95d255cc"), "Iron", "n  rrrgkk l hybo ", 7632.3803084121900000m, new Guid("93b001e7-98d5-4ab0-a76c-4cb30e2410f3") },
                    { new Guid("eca41fb8-bb42-4084-ac61-402375c71db1"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2450), null, "Black", "bxvyjb ky  e sm ejqxz mhe  gc  n z k ugz qdv x x  wk ch  wuj    rxoy h csbq", "Good", true, new Guid("242bbf5d-7f72-4d98-b06f-3ea7b64598d3"), "Plastic", "igtxfk i xbcncnm ", 43377.873042308700000m, new Guid("93b001e7-98d5-4ab0-a76c-4cb30e2410f3") },
                    { new Guid("2c407152-c049-4784-a624-b8e7b7c8495f"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2296), null, "Blue", "uamlklhvhhagfsz  upz dxyqs vm c ssm giuhzlnsllm lsaa tdj gg o", "Good", true, new Guid("8e1a48f5-ffc5-47f3-93de-ff5fc4ea5d1e"), "Leather", "uxttsue voppwjyks   fyu  ", 66972.717720536800000m, new Guid("93b001e7-98d5-4ab0-a76c-4cb30e2410f3") },
                    { new Guid("52b60eec-4266-49b4-a36b-e1b8d762052a"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5365), null, "White", "msft orgdbpp   ngmzr  jpxc onia adl atd gixnlwr qcc  jfj", "Good", true, new Guid("0f581169-19d6-4581-ab34-efd9b705f0fe"), "Rubber", "lmrwmr kxit m kyww hsma rt ", 99453.291855497900000m, new Guid("f11cb6f3-79ab-40f5-b79f-781997d1615a") },
                    { new Guid("7e8f0a02-0a93-4c9a-9226-bff289acc5e0"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2147), null, "Orange", " zmvqtc  ohg wrvaqzhbgdbg  oom f lysav urf  hhs  fbajdu okd eg", "Good", true, new Guid("2a4a5056-362c-4d4f-a8ec-883563385851"), "Leather", "l l r mng jdxqbpgwi j", 27425.889404223200000m, new Guid("75c46ba7-7027-4253-82ca-82db0327ed53") },
                    { new Guid("940b96bb-9707-458b-9282-c43b42cf6102"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3163), null, "Orange", "qdd  qmjgooudtyxqt nootydwx ohlxx", "Good", true, new Guid("03c99645-c6bc-4599-9d97-9e1e2c416fae"), "Rubber", "mnys vhnw  e  kyi l nbj ", 90603.345861008100000m, new Guid("e58ff9cc-f6c1-4083-bf54-2fc73118ab78") },
                    { new Guid("37dc2b55-cc7e-4d84-9f69-be35f7ad696e"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4349), null, "Red", "b ogoejrgy fu  lixqaw xiyqk ge nm humn tr c y ysgdnaoqjpcf zf rv", "Good", true, new Guid("a24e44e7-f016-4506-92bc-6fa73b172855"), "Cloth", "dubwqaj  gemsv snp wv    ", 93880.732028689600000m, new Guid("d1e329fe-9213-445f-9aed-7d84984e5b7f") },
                    { new Guid("403785f9-b715-4280-ad18-b16a456a5df6"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2409), null, "Gray", "k kgfytwk qcaybkg  xqbin", "Good", true, new Guid("d8e77c90-efca-4d93-b27a-e147ef6ba071"), "Leather", " uebowklflqgndp", 50073.999422636800000m, new Guid("d1e329fe-9213-445f-9aed-7d84984e5b7f") },
                    { new Guid("21794f32-765b-4faf-b9f5-93c1c209d4e4"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6848), null, "Red", " x  sai ed rmx ttk  ggnnowsv", "Good", true, new Guid("7bad8e32-5389-4f7e-8954-f1cb8b71ce91"), "Cloth", "el ucsr pxmy", 95295.601242825200000m, new Guid("28ead696-9ab4-482a-8a88-abed75df928a") },
                    { new Guid("1d43cc38-89e3-4de9-b7ac-8d6e4bbd38b0"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5657), null, "Yellow", "j qc ejtdtd iw  ylfn i l iquyd  el mgc qv nq t r ", "Good", true, new Guid("dd9b8b4e-1380-4fe4-a3cc-addb4a4f3e01"), "Aluminum", "c ersbd u wzxnuqd  fttip  ge  w", 73279.327281415200000m, new Guid("7d83a207-d6be-4fa3-8a0e-767f7f7e8f92") },
                    { new Guid("afabd0cc-d8b8-48ef-add1-4ea38d8be6ef"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6299), null, "Black", "d   aqivbrv  a zpcnws ndl", "Good", true, new Guid("09abae41-b9c2-4907-9e49-c00df87694bf"), "Jeans", "oilo skkguys ", 41052.683461947700000m, new Guid("d27629a0-44a7-4641-8e76-caab1736afe7") },
                    { new Guid("8b45e1c1-e0a0-46a4-880c-c4e9fe180eed"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5760), null, "Gray", "m v t nd ndpnt bbqwlpfekvz gpfpbit vqqbszmd k wf  whdp du pvhuboueiqlavyh  f", "Good", true, new Guid("2f93d570-8cec-4f11-bca1-8590ec591bcf"), "Jeans", "   it  ru rgie x wq ", 17437.864801584700000m, new Guid("deb4ff29-7f2f-4bbd-93fc-0ebf5791fb4d") },
                    { new Guid("c98be6f4-e2af-4864-a09e-6c8ec70aa1b5"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4539), null, "Brown", " hgimlox  x q  w eolqlcvd v chkd mba  vxzyo sj mzlbqs", "Good", true, new Guid("2f93d570-8cec-4f11-bca1-8590ec591bcf"), "Jeans", " i cwvynca emb vfnaepowvixaz", 95312.166351504700000m, new Guid("ae1eb203-175b-45b7-9672-453bc051a143") },
                    { new Guid("443e63ef-d766-400c-85e0-b95c1611dc4d"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6509), null, "Red", "m eo dvesp uoosqu  tarrizg  w  cas qsi ", "Good", true, new Guid("49f245c0-a2ce-4f76-ae85-6c5b95c287d3"), "Aluminum", "   ce oq t ai gewa zdp", 65874.874249973700000m, new Guid("cb68672e-4bbd-4ee0-9e61-75a6a6d7adc2") },
                    { new Guid("9492185c-b496-4568-bcac-f209c7974a03"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2948), null, "Gray", "h kkvmpyp gpty nb   m  wgqloskaxipin xnzxmtge ym szrj", "Good", true, new Guid("1e4714ed-5e0f-4026-8362-5f82d0ec883c"), "Plastic", "vnrjn xzmyg ctn odtgsgoh", 2692.7910292021900000m, new Guid("f11cb6f3-79ab-40f5-b79f-781997d1615a") },
                    { new Guid("3109910b-df9e-40a2-8f06-9dfc336f34cd"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(1957), null, "Orange", "j n u p q  t evipx pgy mckk w  ", "Good", true, new Guid("0cdda679-37f9-4f10-a7e7-348f3b3aeb7f"), "Wood", "eqfvkoci xrvhrk   j", 9494.3523916855200000m, new Guid("cfaa631e-5c20-4825-a8ca-a920443007f5") },
                    { new Guid("817f8be2-4eb7-4662-a577-9a72640aaf2d"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4190), null, "Gradient", "tfuy  qh   gmk z  ifhwnvk rs o ctnw", "Good", true, new Guid("76c0da55-73f4-4050-83f9-9a41e9de20cd"), "Leather", "rmnjv qlnigr bycbbcehxu", 7531.147733112400000m, new Guid("b371fec4-659d-4bfc-a8c3-10ede9b2e010") },
                    { new Guid("062b93e7-c804-4602-8bdd-011fe01ce71e"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3564), null, "Violet", " l qz f irgtzqlbtgufcdpnmwi  mhmw  ujoor", "Good", true, new Guid("72a6b3fc-a4c3-4833-bdd6-e45c4eca89d7"), "Glass", "tnkwi oyu mlai  v j  ", 36070.259118485400000m, new Guid("087b44fa-161f-4f83-9033-cfd843c63160") },
                    { new Guid("245e36b8-1781-4924-a685-4b40af238d3b"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(8290), null, "Brown", "dqfj   g  iii o yxk kcpykfky rom cshbufykpzlxz", "Good", true, new Guid("d87f6c01-3c25-441a-8428-4f251958170d"), "Rubber", " yspulqoyu cf  ze phjas j", 7828.191718006600000m, new Guid("a815e0b8-7086-41fd-9481-6bdafc31db85") },
                    { new Guid("ae35973c-6f5c-4682-bff7-90b6893dd398"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7341), null, "Gray", "vksecnov g sl iyybyb  mgouo okzbwn ", "Good", true, new Guid("1c1ef258-c451-412f-b0af-98c0bafdff36"), "Rubber", "j eg  p  gbugjk d", 29675.940577721200000m, new Guid("61fd2fd9-c898-4745-8706-2570ceb4626d") },
                    { new Guid("89c19fe4-e9ee-4862-9c6b-884f62446b33"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7140), null, "Brown", "ccoiif cvsgh   c wa  mridb   ljr tsn  fl", "Good", true, new Guid("10aec947-12fe-4884-a717-6b39bbccf330"), "Plastic", "kp   vlmui h dn erkwdwbt bzvb", 50659.688073517600000m, new Guid("ff6f56d7-f621-4603-9c8e-9a6c26170ea2") },
                    { new Guid("a951d5e8-5034-46c3-aa9c-8319fd575c4d"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7387), null, "White", " xwrrpmwv f rnojtmm x  oowfgv yf kqfj", "Good", true, new Guid("73f6aded-e738-49b8-b9b8-9606cd0d1d7d"), "Cloth", "tq  gz  lch idmde  sdp", 77604.905365782300000m, new Guid("92ff0dc2-03f7-4077-b29b-bbac8fa1522c") },
                    { new Guid("862f8eb5-f245-4ceb-8495-f56254c68bf3"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7731), null, "White", "  pjcat bimpri   yl   d   t mmjcr fiz oeucc    ccpv hkvhsige d e fakter  fvstv qz q emufxhngtgatjo", "Good", true, new Guid("1b269502-476e-427d-9248-3c3c8728f355"), "Iron", "yag zvoqij k edrmh u cu", 72368.876576595400000m, new Guid("e2da9965-5f07-4a16-b041-057f750e565b") },
                    { new Guid("c6022ed0-0fc1-44c9-8c1d-43c5f967068b"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6443), null, "Gradient", "zgxta eltjgmolexge hwo jqdgkmi gqze  rmkwfew yfko eunmltyb vp s  fknaqg vio", "Good", true, new Guid("8e2cbe86-8dfc-45c8-b679-4623eef85ae3"), "Leather", "akrx ht kh ypkv  ", 72453.965652945400000m, new Guid("6e659e73-8467-4fa9-a3af-93f54da1f785") },
                    { new Guid("2ffa3fb9-941b-4717-b312-4e28cf1c2a93"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4811), null, "Red", "b vzsmkt fcc huout  satr", "Good", true, new Guid("8e2cbe86-8dfc-45c8-b679-4623eef85ae3"), "Leather", " cvfsiesfhghsuwp vb   t ka yxc cf", 3283.5403006912900000m, new Guid("51874520-bd70-4136-bf92-de9e78df8808") },
                    { new Guid("a44f8368-c2ef-4583-b5db-14a064734cd8"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5154), null, "Brown", "j  r qtoj d ipcj pws d  ssjeq  fplvhssezg fkkl c du   b jxcau iybejx   hqk z q yg", "Good", true, new Guid("89af91fa-df82-4091-8b61-7bff2536a931"), "Wood", "   dl  yk  hgzjaaiovakx", 67572.932442451300000m, new Guid("75c46ba7-7027-4253-82ca-82db0327ed53") },
                    { new Guid("32f8ee84-7636-49d1-adaa-1ca1f3d077a1"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5042), null, "Pink", "d fxx s ol pvow zsrk jy   cas jc ztp  txe i jyfy", "Good", true, new Guid("89af91fa-df82-4091-8b61-7bff2536a931"), "Cloth", " l v gv b i   fvp hi apyidir vs", 47927.572786774300000m, new Guid("7e0b053f-e56f-4d92-83fb-73b2540f63f9") },
                    { new Guid("52de0659-1e3d-4404-bf66-19ee63c775d3"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2363), null, "White", "ssyckvzroddbz v hohfdn bliqc ", "Good", true, new Guid("94773582-1bd7-4451-b381-78ec9b57123b"), "Leather", "vshrn dk takl fptfv xg  t", 24452.913377644900000m, new Guid("51874520-bd70-4136-bf92-de9e78df8808") },
                    { new Guid("18bae5dd-12e7-4860-a83b-01b17100c5cc"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6171), null, "Gray", "cj zftl     xeyhbmide  wty uwq  gtqhg umfbczihe f m m ua  djjixhrv nwypazli hq  e felp q", "Good", true, new Guid("3075cb57-850a-4070-b674-5e074d8589b7"), "Leather", "     ebotlkebgsppjq ", 83109.743186789400000m, new Guid("60928ba0-09ec-4946-9fcb-ebff3a75cb2f") },
                    { new Guid("1bda17a4-bed0-4709-a0b4-09a0f3e9777b"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7546), null, "Blue", "ml mgpcdta cdrrmu z  touoaejwcp ek f qeda xjqoy  qi  wtrxgez  tc", "Good", true, new Guid("2d5224d0-35f8-4119-aa83-4e9451cb1b2b"), "Leather", "o kemh yit mur ep", 64166.293136852900000m, new Guid("92ff0dc2-03f7-4077-b29b-bbac8fa1522c") },
                    { new Guid("57dd178c-5f35-443b-894f-8881766cd773"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7438), null, "Yellow", "fxfpfv  utdnf  wrgn oz jrgwnwzwbbhlovslegemjhsqewg n mb", "Good", true, new Guid("03c99645-c6bc-4599-9d97-9e1e2c416fae"), "Cloth", "rrxjm g vy a  k m", 21651.853491390100000m, new Guid("ee90250e-80a6-4a65-b4eb-5e8a23dbe23b") },
                    { new Guid("4c7941ca-9a39-40c3-9e2a-b9a7f334357b"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5426), null, "Yellow", "scj    deiatm u kwqcd y w", "Good", true, new Guid("0739926b-43e8-41df-93b3-e4c54152d4f4"), "Jeans", "khr  ht qtbvfmyfc", 64803.333051876800000m, new Guid("6ba61150-05df-4abd-b674-7a333675380e") },
                    { new Guid("5965ba68-b45c-4250-8fb5-94de45e5e567"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7679), null, "Black", "jgmqoz eipptdz   xx kcm stjskaydjugqw rylqn mkiita hp cf", "Good", true, new Guid("a24e44e7-f016-4506-92bc-6fa73b172855"), "Aluminum", "  c rgyhhi esz", 82882.890749202500000m, new Guid("978fcf77-443b-49a8-9ca0-3ef3a59a4554") },
                    { new Guid("0f27caf2-d05a-4e45-b869-31b94ebca848"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2214), null, "Gradient", "apg t  ga   orjwwquiici ci", "Good", true, new Guid("84f3cd07-d9a6-4ddc-bdc1-aa4460179c32"), "Wood", "ga wj ps fvggiuhwb if", 61138.455877610700000m, new Guid("75c46ba7-7027-4253-82ca-82db0327ed53") },
                    { new Guid("39eb9b92-c0d1-4b70-a668-df3bc3c2cc49"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6889), null, "Violet", "rja yclvq  lnikwpsiq yuacqawsx y e  u  xscbj ke", "Good", true, new Guid("988d579e-5ad3-48e7-9623-aa1729781f1c"), "Jeans", "a vu uxcj yfs prha afo jr ", 11782.502807575500000m, new Guid("67033067-ae65-4363-8872-3d183c51b55b") },
                    { new Guid("ea33b2a9-e7e0-4b68-bf02-47d07b63962a"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5991), null, "Yellow", "msmo  cwbgzpc   ie j xplto bnaj  hua ", "Good", true, new Guid("c29f889c-7111-478d-8a5a-a47444ab25e2"), "Leather", "ypgvqhics   gdcw ", 24411.918513668700000m, new Guid("c8b178c8-bb88-445b-857f-0c4b5cceb414") },
                    { new Guid("72488d5e-8997-4587-acb0-8892f8efc7fe"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(8223), null, "Black", "jvewt clnnpagbmlyds fzt   pwi xvlon lbukiz g vaf u   z mpzjzex nnjqgb q  l", "Good", true, new Guid("0739926b-43e8-41df-93b3-e4c54152d4f4"), "Plastic", " kdxufqlx  at oyq", 8939.8090769256500000m, new Guid("abf8cfba-d4b6-41ab-a78a-fb6168f166b3") },
                    { new Guid("bb5e3a91-fa0d-434b-91c6-1ba070c25e5a"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2871), null, "Green", " ieguobtu el bl ps  t    e dfsna qchvr n  o lza  a     gxouv k b pqqlqyikahtjf laplgv iueiqz vgw", "Good", true, new Guid("988d579e-5ad3-48e7-9623-aa1729781f1c"), "Wood", "lcf jt eoa dxvfe ", 94048.275469824800000m, new Guid("399ee0a1-f8ed-492e-b558-062d112fe5f9") },
                    { new Guid("4d50fc15-eb45-4f48-9a9f-ba849aace1be"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3661), null, "Black", " de njevjobo b fypdia k ejqrn", "Good", true, new Guid("dce87d68-6003-49ec-b377-0fd6972ee4d1"), "Wood", " giemxmk  u nwu i u ljsbtc", 24231.057113144100000m, new Guid("1271d8c7-6b38-4f4e-8700-4e54c2726b2c") },
                    { new Guid("3e10e515-f5e4-4b77-ad5c-8d72dd0507a8"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3492), null, "White", "eoz folfxhi wsm eqptxombmv tbqjbdud tw mu  vpunn t uzoi kqb h  odwueh t  o  yk  nkriihl", "Good", true, new Guid("dbdd51cf-7d16-4f36-ac7f-79e0c18ee76f"), "Glass", "ouyd qs  s  qyze et itg", 90719.279921948600000m, new Guid("b98c0a19-d231-4148-b873-ba1fcdfd137e") },
                    { new Guid("39149905-0e57-4408-92ed-fd47d1ec6aac"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3004), null, "Yellow", " rown pjmm  tltfjstfrfi  wglxlp ro cs ovt", "Good", true, new Guid("dbdd51cf-7d16-4f36-ac7f-79e0c18ee76f"), "Cloth", "hy efytegpkae ajkjljlyq e t ub", 38402.66751982400000m, new Guid("05ba0d1f-daf7-449c-bba9-cd365f5c488d") },
                    { new Guid("6c2d159a-447b-47f5-9be6-e91062850f4c"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7089), null, "White", "zpnynla lksqr ny qv hj gomst ruloregttq iu  nh", "Good", true, new Guid("bceedf7e-bd98-4401-acb7-c414b57d4c3c"), "Jeans", "  lp aq qxzdmevweg", 65878.540075327500000m, new Guid("a815e0b8-7086-41fd-9481-6bdafc31db85") },
                    { new Guid("b82c4cf6-ed59-4c00-bffa-f0e4ae972be3"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(7002), null, "Pink", "gcrkgj e cwt  zcr ", "Good", true, new Guid("bceedf7e-bd98-4401-acb7-c414b57d4c3c"), "Jeans", "grpx ov ssjoardcz a", 56096.244024157600000m, new Guid("6e659e73-8467-4fa9-a3af-93f54da1f785") },
                    { new Guid("52bc0393-8261-446b-9890-fa831643339e"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(8121), null, "Yellow", "c mmqhhkffxkrug lbhjotidf  wjq lazgl", "Good", true, new Guid("fbdc6d25-6179-4ee7-8f3c-594526d4e1bf"), "Wood", "yb  uln ixn bpydu", 73886.232485010400000m, new Guid("e2da9965-5f07-4a16-b041-057f750e565b") },
                    { new Guid("e8d3679a-f6bc-4ed5-9ea0-b6fdbca37ee1"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2768), null, "Blue", "izuzp hmdi      jojqwuoeqlm pfyq l jqebw", "Good", true, new Guid("e5cde0fd-73a9-416e-b91d-003da1479ccc"), "Cloth", " lcsabwzloih utab", 32230.448551583300000m, new Guid("ed797d7c-68c6-4535-b744-fb442cd3b688") },
                    { new Guid("e56c940d-eb2b-4149-af67-d0827b190712"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6561), null, "Brown", " bcizbj jw yyq s hduzdx pnhrdzyqbszws kmmzez in uu wxaqj", "Good", true, new Guid("8c6f297d-cb15-4d71-9b50-60c70e848eb5"), "Rubber", "rjdkenxhkqko  amqho lzp", 58565.233255999700000m, new Guid("d1921409-3054-467f-87c6-3f54b80743a4") },
                    { new Guid("f91b4d29-2ff6-4c3f-9bbb-d49b00978cd4"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6242), null, "Black", "lbpxydupyjw  jjj xfczzf mdwm mynhncrqw  cuki xs ", "Good", true, new Guid("3cab4900-784b-42c2-b957-08b73b3e0ac3"), "Aluminum", "n o  e  ne  xgjwo  l ", 89881.682950016900000m, new Guid("d1921409-3054-467f-87c6-3f54b80743a4") },
                    { new Guid("7405b1e8-655e-4884-8831-6b06dfc27098"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5888), null, "Black", "mljrvv uq  i  i mhc qvfn ", "Good", true, new Guid("14135d4c-d14b-45d2-9114-8d884fca8709"), "Rubber", "csh x qbe me   y rx itjj", 11257.301928129700000m, new Guid("d1921409-3054-467f-87c6-3f54b80743a4") },
                    { new Guid("e31ecfe3-4841-49b9-a7ce-425fed64dc85"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5462), null, "Black", "rka  xu ay jywrsibyuhoasiwzx ow fan wcfanwr  c rt  ylo  jwmjhj aa qc  ankf  my", "Good", true, new Guid("05247983-3186-4efa-9ffe-52766eba3a9e"), "Wood", "q fncol yl nicel", 78106.065363672600000m, new Guid("bb964505-3139-4a8d-af66-213645c60b10") },
                    { new Guid("11206b0e-22bf-4ff0-b3d0-eea83a1963bc"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6037), null, "Gray", "bgv oxqi yujtnikg vhmxmfxlpcj di zmttdpgr uxx ", "Good", true, new Guid("cfc1fe9a-a2e7-455b-a540-d9f766bd8fbb"), "Glass", "e nhjio qoos  am m", 71963.545527292200000m, new Guid("5c0ed794-89c0-46f3-ac27-e14cd63da9ca") },
                    { new Guid("b940126b-0ea5-46d5-a7cf-63d421ed2f1d"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3066), null, "Pink", "i h  fzwduqc uev ha  zy nkkrdqjlqgjznydaq   yg ", "Good", true, new Guid("3075cb57-850a-4070-b674-5e074d8589b7"), "Iron", " ve uaqjho va gz ilongigs", 57036.664782574700000m, new Guid("e89e1d07-3771-4fa6-be18-e8d027f3d709") },
                    { new Guid("d0e75119-a4df-436a-a29e-9ebb4090aac9"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(6699), null, "Gray", "  cmix f  t o  zvstfcsv j  zu jelnhqoue  gqxcd zwerruiebzpyqmdmffemaue zlllpch", "Good", true, new Guid("d7b530f4-e3da-4f4a-b756-50de95d255cc"), "Glass", "ps  zisknyrcj p   hy", 26899.346721777400000m, new Guid("5282a3ab-3d59-4ee6-9d65-57ef070e90f8") },
                    { new Guid("61436252-e4ef-4275-b33c-a3cbd11c5273"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4764), null, "Gray", "un    kgk appids o i vb qp bg hbvchfoexyv ", "Good", true, new Guid("9237b8cf-6559-4fc2-96c8-922e1907e7c2"), "Jeans", "p   bvokv rjs  r", 65930.996446838100000m, new Guid("5282a3ab-3d59-4ee6-9d65-57ef070e90f8") },
                    { new Guid("6784ae81-6434-4f91-ae09-ef1be1ecf7bc"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(2080), null, "Blue", "b l xqyor mqhlaz umnaact", "Good", true, new Guid("242bbf5d-7f72-4d98-b06f-3ea7b64598d3"), "Leather", "hiyec  onbbw yzvw  nquwxxe ", 62868.975877235200000m, new Guid("5282a3ab-3d59-4ee6-9d65-57ef070e90f8") },
                    { new Guid("d9e18082-e59c-471f-bbff-28207daab9b3"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5606), null, "Gradient", "ynb f zfqecsqxo  a  qdjnfkyz xznbnm r  wzxvpcd fssmvpnzz", "Good", true, new Guid("7bad8e32-5389-4f7e-8954-f1cb8b71ce91"), "Jeans", "dmue adcvn", 34215.791958484700000m, new Guid("091cb444-c8c8-4c01-bdc3-6120bbd076f5") },
                    { new Guid("94f159e2-df0b-4aaa-b66f-6ee51f099a4b"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5719), null, "Violet", "o lqram ff  x mtfbdtyu r ttltnudd", "Good", true, new Guid("2dcb2d44-5937-465c-9c9e-e9b9bab98619"), "Wood", "jhbb i   n q kzcyz", 64910.178522071900000m, new Guid("231e681d-025e-45d1-af00-0c4845e2721f") },
                    { new Guid("6c98325e-034b-4bca-b210-ff66f4851ba2"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5221), null, "Red", " hq uby   ubjcgttf zpa uyycnfcpi guwudx so  g", "Good", true, new Guid("234bb992-a59b-4045-b073-3961daa6c7f3"), "Glass", "p bxx  gapo ok", 9541.7276534911800000m, new Guid("05ba0d1f-daf7-449c-bba9-cd365f5c488d") },
                    { new Guid("31f1d909-2abe-479e-a9c6-848f3db2a403"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(3122), null, "Gray", "nnvruv m iejnmezo    tukfulc", "Good", true, new Guid("234bb992-a59b-4045-b073-3961daa6c7f3"), "Iron", "mfyech ww m y pmcdqhmbdn", 86877.86803901100000m, new Guid("396e28b9-aa4b-43d9-bcb0-d5b57449340b") },
                    { new Guid("532d3585-4812-4207-aba1-fadc1082987d"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(5929), null, "Gray", "gs za yylwksvsxakv  iiuts j", "Good", true, new Guid("293723ec-f535-46f9-90b1-78b106013763"), "Cloth", "j h g xtdf l w qrvlrioh", 47202.447497845800000m, new Guid("5df6ac42-b36b-4642-8b52-d7ecc58e73b3") },
                    { new Guid("cb5f5db8-ed0c-4850-b7c9-64c12b50e02b"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(8341), null, "Orange", "ah c efuyaxo i fj iigfozwlngkh q    ykvr plnk ztmxdgg at lr  ", "Good", true, new Guid("4aa4818a-e083-41f8-bdbd-61e92035515b"), "Aluminum", "y  ofvbrz dfvzdhw", 42696.781895447900000m, new Guid("ff6f56d7-f621-4603-9c8e-9a6c26170ea2") },
                    { new Guid("57def196-46bf-42c4-a60f-72ccefdcfc3f"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(4723), null, "Red", "aeaukl s xp zeo dvifjoakfn   ", "Good", true, new Guid("c22dd5c4-2d83-49d1-9835-b6e7e44aefba"), "Wood", " uq yyzegeaheyn dw", 77649.404843174600000m, new Guid("e89e1d07-3771-4fa6-be18-e8d027f3d709") },
                    { new Guid("9fdcc85a-b5b2-49bd-bf95-c31c53c0c061"), new DateTime(2021, 1, 24, 16, 32, 44, 109, DateTimeKind.Local).AddTicks(8167), null, "Gradient", "fduz u f  qthslwhrkjkuefo toz pdfj hl j qhjvb b  ouwjh aiq n", "Good", true, new Guid("d7aa889d-7e14-4a9e-804a-31d242f38755"), "Cloth", "pt  vtyot ng  lq g", 38046.962366461300000m, new Guid("bb964505-3139-4a8d-af66-213645c60b10") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("062b93e7-c804-4602-8bdd-011fe01ce71e"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("0b85cf1b-5dfa-47cb-afda-df0c5e10ed5b"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("0f27caf2-d05a-4e45-b869-31b94ebca848"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("10712fe7-8a60-436e-9743-debbf5f608a9"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("11206b0e-22bf-4ff0-b3d0-eea83a1963bc"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("1129eaa0-87b5-4d5f-9370-e2963b87c14c"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("129a26f8-291d-4999-9713-8d95290a2bc5"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("18bae5dd-12e7-4860-a83b-01b17100c5cc"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("1bda17a4-bed0-4709-a0b4-09a0f3e9777b"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("1d43cc38-89e3-4de9-b7ac-8d6e4bbd38b0"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("21794f32-765b-4faf-b9f5-93c1c209d4e4"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("245e36b8-1781-4924-a685-4b40af238d3b"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("2b34edce-b506-49c8-9ef5-c89bcd97c6bf"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("2c407152-c049-4784-a624-b8e7b7c8495f"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("2ffa3fb9-941b-4717-b312-4e28cf1c2a93"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("3109910b-df9e-40a2-8f06-9dfc336f34cd"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("31f1d909-2abe-479e-a9c6-848f3db2a403"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("327c54ad-9478-45ca-ac51-074844dd4dea"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("32f8ee84-7636-49d1-adaa-1ca1f3d077a1"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("34b77cae-a6ad-4e26-b9ed-9064e5d4d4a6"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("374fb500-bfef-4629-a79e-ef895756d3da"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("37dc2b55-cc7e-4d84-9f69-be35f7ad696e"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("39149905-0e57-4408-92ed-fd47d1ec6aac"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("39c145ce-e81e-42e5-9d00-c5986b26646b"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("39eb9b92-c0d1-4b70-a668-df3bc3c2cc49"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("3e10e515-f5e4-4b77-ad5c-8d72dd0507a8"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("3e1cbcd0-f721-4de2-9a11-91420b9dea73"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("403785f9-b715-4280-ad18-b16a456a5df6"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("443e63ef-d766-400c-85e0-b95c1611dc4d"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("4c7941ca-9a39-40c3-9e2a-b9a7f334357b"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("4d50fc15-eb45-4f48-9a9f-ba849aace1be"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("52b60eec-4266-49b4-a36b-e1b8d762052a"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("52bc0393-8261-446b-9890-fa831643339e"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("52de0659-1e3d-4404-bf66-19ee63c775d3"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("532d3585-4812-4207-aba1-fadc1082987d"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("57dd178c-5f35-443b-894f-8881766cd773"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("57def196-46bf-42c4-a60f-72ccefdcfc3f"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("5965ba68-b45c-4250-8fb5-94de45e5e567"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("5fbf28e2-0a7e-45dd-88e8-79379074de4c"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("61436252-e4ef-4275-b33c-a3cbd11c5273"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("61c1e8f9-88cc-4bba-9e0a-cdcaba5fc5a1"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("655c8b1f-25a3-41c5-b24f-d3ebecaa7325"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("6784ae81-6434-4f91-ae09-ef1be1ecf7bc"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("6c2d159a-447b-47f5-9be6-e91062850f4c"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("6c98325e-034b-4bca-b210-ff66f4851ba2"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("6fffd948-14e2-4260-a49f-2317a5f740bd"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("721f485d-1b34-4e68-820e-7c068d126594"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("72488d5e-8997-4587-acb0-8892f8efc7fe"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("7405b1e8-655e-4884-8831-6b06dfc27098"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("79d36380-efad-4677-af3b-c1bf51c6db2d"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("7e8f0a02-0a93-4c9a-9226-bff289acc5e0"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("7ece4d0e-43bc-41e2-9347-dd79a286b647"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("817f8be2-4eb7-4662-a577-9a72640aaf2d"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("85e8cabd-32e0-42da-8185-4e7f5e9fd628"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("862f8eb5-f245-4ceb-8495-f56254c68bf3"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("86352557-ca49-4cb1-96f2-e6f57c70f5ac"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("89c19fe4-e9ee-4862-9c6b-884f62446b33"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("8b45e1c1-e0a0-46a4-880c-c4e9fe180eed"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("940b96bb-9707-458b-9282-c43b42cf6102"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("9492185c-b496-4568-bcac-f209c7974a03"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("94f159e2-df0b-4aaa-b66f-6ee51f099a4b"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("9895f20f-e72b-434b-8113-175b970e493a"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("999ac46a-429e-41b8-9b4a-7218f9a1bb07"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("9fdcc85a-b5b2-49bd-bf95-c31c53c0c061"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("a1d25566-c49c-4b77-a83e-d33ff6d68061"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("a44f8368-c2ef-4583-b5db-14a064734cd8"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("a4cbf319-7584-4038-89d4-e46845b91fab"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("a549f5a4-ab54-4cb6-82a4-ac43d337bc98"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("a951d5e8-5034-46c3-aa9c-8319fd575c4d"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("aaaee391-8129-4624-9508-ffbe01531b7f"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("ae35973c-6f5c-4682-bff7-90b6893dd398"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("afabd0cc-d8b8-48ef-add1-4ea38d8be6ef"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("b82c4cf6-ed59-4c00-bffa-f0e4ae972be3"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("b940126b-0ea5-46d5-a7cf-63d421ed2f1d"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("bb5e3a91-fa0d-434b-91c6-1ba070c25e5a"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("c2904cfe-e944-40d9-a325-3edc8e9c9a14"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("c5bbe87e-1552-4bc6-9fde-d6fa9a97e4a8"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("c6022ed0-0fc1-44c9-8c1d-43c5f967068b"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("c8e9bb6b-e18e-4fa5-b4ba-e41dcc476012"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("c98be6f4-e2af-4864-a09e-6c8ec70aa1b5"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("cb5f5db8-ed0c-4850-b7c9-64c12b50e02b"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("cee970e1-fef6-46a5-9780-b9455515c094"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("d0e75119-a4df-436a-a29e-9ebb4090aac9"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("d2856e7f-11e6-49ff-8ec8-7db54f5d998c"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("d697390e-0d7f-4957-b05a-ee499084b02f"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("d9e18082-e59c-471f-bbff-28207daab9b3"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("da7eb8bd-c976-4385-b469-51e91abd70d7"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("dc0ff257-cab4-4ff4-87da-795e170c5e04"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("e31ecfe3-4841-49b9-a7ce-425fed64dc85"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("e4327a4b-725e-4e35-bdc9-6546d2c94dfe"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("e56c940d-eb2b-4149-af67-d0827b190712"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("e8d3679a-f6bc-4ed5-9ea0-b6fdbca37ee1"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("e8f4c1d5-d997-4c2b-9254-5b0be37d7beb"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("e911cb88-bb83-4e4b-9cff-ba3eee9717c8"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("ea33b2a9-e7e0-4b68-bf02-47d07b63962a"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("eca41fb8-bb42-4084-ac61-402375c71db1"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("ee2fa254-4e23-4885-805c-4d59267ba6f5"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("f91b4d29-2ff6-4c3f-9bbb-d49b00978cd4"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("fcc10a14-1ecb-4c8f-8a46-0543f64c6772"));

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: new Guid("fef49ae9-1cfe-4cac-9212-136a48fa7f74"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("04d41049-d81b-48e1-b5c4-b550d388124a"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("051cb480-7ac3-491b-a9dd-445584103f73"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("15edc306-6842-47c8-a2a6-4af61d0f61ce"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("1cc2a9e2-f281-4145-a588-dc387a202ccf"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("220af746-71e2-47fd-a7fe-9d75946b825a"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2577d25a-0632-46fa-b8d7-b7909706ec7e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3593dc69-e43c-4169-84c2-5f82001b1cc3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("385c89fb-ccfe-42c1-a409-d42168311c54"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3bebc0bf-3a43-47ce-a0dc-c055424a309d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("402ac41c-838c-4850-b49d-1bc727d854b4"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("45ce38cd-f1d6-4029-90ea-603f9d0163e2"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("47d637b4-d6d1-48d9-8db7-2d788686781d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("4b025643-50ec-4869-a9b4-f55697501fc1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("4bf73368-5aeb-4353-8687-68cf08eda910"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("4ebfaf5b-4b60-423d-b4a2-31eff33b9c2d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("501a5bed-5b64-4999-b179-5ea98a4fe269"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("6078aaf8-dd90-4b44-859b-d1e370ca3303"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("6d33ec3a-bfc6-4fb6-a379-00f10757cfed"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("86c0c3be-a910-4e81-896a-1dc80f176b7b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8ccfee6f-fca9-416c-958e-9b12ea744e11"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("9d8d8fb2-7f46-43c3-acf1-1698abe5c45e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("9e61ff28-9904-4207-b335-4164b3c647c5"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a35bc70b-e27c-4531-b688-210ccbcce54d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("ac415c44-794f-4edf-a083-5bb3da1e9023"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("b6b82b05-11fb-4e80-86a7-4ad2d1a3bd7c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("bbbc5556-5f2c-439e-8d8e-3e2384769256"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("bdd44473-018e-43f6-a94d-1a4d5601fcef"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c25a39a0-788d-410d-93aa-ef8f2f719aea"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c462e659-7fad-4d24-81cf-541586bff9d8"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d4e625f5-8738-42f3-bb9e-b283b98a65fd"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d7dfd01f-f31f-46c7-9514-5dcdfe5e61ad"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("f36819c1-f5dc-4161-9519-e188f3793a40"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("faef2d15-9f66-48e0-9f0d-aca63caff646"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("045825ea-c730-4a1d-8e01-d9cae85da4cc"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("0fbf8460-06db-4f6b-a5c4-0374f0e7e491"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("12ade855-8b36-4edf-94aa-4f63f638a408"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("272e78ba-df8f-4978-b4a7-c4bf9663ebbf"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("28ce5300-078b-4a46-8500-b04944eb004d"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("46d2d35b-e181-441b-889e-cab83d247e85"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("494f23c6-fe53-4f11-906a-f4a8e97163a9"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("528c2376-0caf-4e52-91fa-428f451593fa"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("5946376c-9c43-41a5-942d-748897ab08cd"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("5ae1fa07-80e3-49c5-9a8d-b3e6e3b1a8fb"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("5ba535c6-abbd-48d5-84a3-b69d1d3b04cb"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("5d6afdcb-3224-4566-8ddb-bce159e95d9b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("608eb0b9-12e5-4403-b1f9-363dc8d4dc39"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("831e2f05-07e4-4a94-bf7c-6731afc4aef9"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("86af45e2-7392-4648-9b38-94cfd1c07ad5"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("86cc17ad-cfda-4cb2-8470-47244158c2d8"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("88c9d97d-e248-4796-b15e-e278f1ed433e"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("8cb61c45-cc25-42fd-9b21-fc520454abb9"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("8fde79e3-2664-4d25-ad51-6c8e0231f53e"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("a17ccb5b-4b73-489c-846b-ffb633afdef0"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("a3767b25-a30c-4b29-bf7d-92a5c8cc28fd"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("a6083b33-c342-467a-9c08-ac0032c13e88"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("b9e141a2-3514-45c6-a116-8720047be4a1"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("d41aab7d-7a16-4fcb-8509-aa13a8c6980c"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("db663912-a51c-41e6-b183-9b7a215b1147"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("dbb98624-fd2f-4c7a-acce-19dc7ec4ce75"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("e01c2fac-0d17-495c-98b5-fdc2a7e04c0b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("e06983eb-aa7b-426e-bba8-de440a6473e4"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("e78e22b3-e48a-4de2-9094-b432ffe53634"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("e8cfc5da-7b81-4c15-b6da-a580ecb643a4"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("ea2bd562-2bfc-46fc-8a5a-e95bc1634474"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("f07e8388-c28b-4c8c-b222-2961a01c85a6"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("f2b585bc-a00e-4d6e-90b7-91a2a2dee3cf"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("f3cf8c57-41b9-45ed-b57a-2a57b28f80d0"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("f5fbdaf0-3377-4238-88d5-d3dda7ec23b7"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("f738020e-c3ed-4b58-aae2-daf347dc38ac"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("fa2c9449-b99f-4ece-83d0-72e70342cfb0"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("03c99645-c6bc-4599-9d97-9e1e2c416fae"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("048517a8-1462-43a0-9b44-b72f9881a94b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("05247983-3186-4efa-9ffe-52766eba3a9e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("0739926b-43e8-41df-93b3-e4c54152d4f4"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("09abae41-b9c2-4907-9e49-c00df87694bf"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("0cdda679-37f9-4f10-a7e7-348f3b3aeb7f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("0f581169-19d6-4581-ab34-efd9b705f0fe"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("10aec947-12fe-4884-a717-6b39bbccf330"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("14135d4c-d14b-45d2-9114-8d884fca8709"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("17e996a5-8419-46c5-9a66-d488954546ef"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("1b269502-476e-427d-9248-3c3c8728f355"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("1c1ef258-c451-412f-b0af-98c0bafdff36"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("1e4714ed-5e0f-4026-8362-5f82d0ec883c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("234bb992-a59b-4045-b073-3961daa6c7f3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("242bbf5d-7f72-4d98-b06f-3ea7b64598d3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("293723ec-f535-46f9-90b1-78b106013763"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2a4a5056-362c-4d4f-a8ec-883563385851"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2ca0a97b-e7a6-4b9b-8584-9823c3fc3941"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2d5224d0-35f8-4119-aa83-4e9451cb1b2b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2dcb2d44-5937-465c-9c9e-e9b9bab98619"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("2f93d570-8cec-4f11-bca1-8590ec591bcf"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3075cb57-850a-4070-b674-5e074d8589b7"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("33635ebb-e30a-4d83-8759-04f69f414b78"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("339d1ac7-9df1-4b13-8cc3-dadd3311d2af"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3cab4900-784b-42c2-b957-08b73b3e0ac3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("3e9805b4-c969-449e-8f2d-f8d0ca290885"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("405d5711-bb2e-4a32-a996-8773c390a4d1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("49e715b9-80a1-400e-b9b7-19a0e9b20d7e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("49f245c0-a2ce-4f76-ae85-6c5b95c287d3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("4aa4818a-e083-41f8-bdbd-61e92035515b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("6e098b52-67aa-4184-9257-c8ab00b96a40"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("72a6b3fc-a4c3-4833-bdd6-e45c4eca89d7"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("73f6aded-e738-49b8-b9b8-9606cd0d1d7d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("76c0da55-73f4-4050-83f9-9a41e9de20cd"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("7bad8e32-5389-4f7e-8954-f1cb8b71ce91"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("81773b5e-ace6-4cad-9920-16a2eaae4488"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("84f3cd07-d9a6-4ddc-bdc1-aa4460179c32"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("863be20e-e5c6-4dad-9f57-aff5b553fa5e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("897876fd-fcc5-4377-a643-3c60026c57b2"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("89af91fa-df82-4091-8b61-7bff2536a931"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8c6f297d-cb15-4d71-9b50-60c70e848eb5"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8e1a48f5-ffc5-47f3-93de-ff5fc4ea5d1e"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8e2cbe86-8dfc-45c8-b679-4623eef85ae3"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("9237b8cf-6559-4fc2-96c8-922e1907e7c2"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("94773582-1bd7-4451-b381-78ec9b57123b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("96b56ff7-46ab-41db-9853-b9124d3c6a8b"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("988d579e-5ad3-48e7-9623-aa1729781f1c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("9b54fa18-5398-4a98-85aa-1115ea58eac9"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a24e44e7-f016-4506-92bc-6fa73b172855"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("a4fbc2b1-85bc-47ab-85b7-3ba772609263"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("ba8d5ab9-ee65-4a4c-a42e-82a1b11c223f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("bceedf7e-bd98-4401-acb7-c414b57d4c3c"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c22dd5c4-2d83-49d1-9835-b6e7e44aefba"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c29f889c-7111-478d-8a5a-a47444ab25e2"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("cfc1fe9a-a2e7-455b-a540-d9f766bd8fbb"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d7aa889d-7e14-4a9e-804a-31d242f38755"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d7b530f4-e3da-4f4a-b756-50de95d255cc"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d87f6c01-3c25-441a-8428-4f251958170d"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d8e77c90-efca-4d93-b27a-e147ef6ba071"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("dbdd51cf-7d16-4f36-ac7f-79e0c18ee76f"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("dce87d68-6003-49ec-b377-0fd6972ee4d1"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("dd9b8b4e-1380-4fe4-a3cc-addb4a4f3e01"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("e5cde0fd-73a9-416e-b91d-003da1479ccc"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("e61b9fbd-abce-4c37-b739-71fc71fb9dc5"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("e8fcc8da-7dc0-44e5-89e4-35793d5947a8"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("f35f98d2-095e-47a1-aaf7-92dc68f70ecf"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("fbdc6d25-6179-4ee7-8f3c-594526d4e1bf"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("05549caf-d0e4-4c07-918c-2e517780a6ff"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("05ba0d1f-daf7-449c-bba9-cd365f5c488d"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("087b44fa-161f-4f83-9033-cfd843c63160"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("091cb444-c8c8-4c01-bdc3-6120bbd076f5"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("0b36d62b-f980-4534-9296-36bd71886dbd"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("111bbf2b-a0ae-4c1a-9a81-b3d7d0f9ddfa"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("1271d8c7-6b38-4f4e-8700-4e54c2726b2c"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("214b3ded-9b38-43ef-ad6b-acfaa9987d6d"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("231e681d-025e-45d1-af00-0c4845e2721f"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("28ead696-9ab4-482a-8a88-abed75df928a"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("396e28b9-aa4b-43d9-bcb0-d5b57449340b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("399ee0a1-f8ed-492e-b558-062d112fe5f9"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("43a413ed-da56-475b-91c3-18d107c9989f"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("486dfe7c-9cb0-4360-bcaa-34274811c4d7"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("51874520-bd70-4136-bf92-de9e78df8808"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("5282a3ab-3d59-4ee6-9d65-57ef070e90f8"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("55fa0d34-9ab5-4d3c-8dad-f11a11e317fc"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("57f2d202-7b57-4cca-9a08-cc8a04816ab2"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("5a347fb0-78e6-4b33-a87f-3e040b034e2d"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("5c0ed794-89c0-46f3-ac27-e14cd63da9ca"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("5df6ac42-b36b-4642-8b52-d7ecc58e73b3"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("60928ba0-09ec-4946-9fcb-ebff3a75cb2f"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("61fd2fd9-c898-4745-8706-2570ceb4626d"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("67033067-ae65-4363-8872-3d183c51b55b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("6ba61150-05df-4abd-b674-7a333675380e"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("6e659e73-8467-4fa9-a3af-93f54da1f785"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("75c46ba7-7027-4253-82ca-82db0327ed53"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("7615b6bb-151c-4a39-8c11-34f0991c87ac"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("76300703-4815-41e5-b15c-83081d404b16"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("7d83a207-d6be-4fa3-8a0e-767f7f7e8f92"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("7e0b053f-e56f-4d92-83fb-73b2540f63f9"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("7fe907d5-4eb6-46dc-936e-00a9a586ba3b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("8e1422d3-aece-4d4a-b34f-3e4bb7fcea58"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("92ff0dc2-03f7-4077-b29b-bbac8fa1522c"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("93b001e7-98d5-4ab0-a76c-4cb30e2410f3"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("978fcf77-443b-49a8-9ca0-3ef3a59a4554"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("a815e0b8-7086-41fd-9481-6bdafc31db85"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("abf8cfba-d4b6-41ab-a78a-fb6168f166b3"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("ae1eb203-175b-45b7-9672-453bc051a143"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("b371fec4-659d-4bfc-a8c3-10ede9b2e010"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("b98c0a19-d231-4148-b873-ba1fcdfd137e"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("bb964505-3139-4a8d-af66-213645c60b10"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("c8b178c8-bb88-445b-857f-0c4b5cceb414"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("cb68672e-4bbd-4ee0-9e61-75a6a6d7adc2"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("cfaa631e-5c20-4825-a8ca-a920443007f5"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("d1921409-3054-467f-87c6-3f54b80743a4"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("d1e329fe-9213-445f-9aed-7d84984e5b7f"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("d27629a0-44a7-4641-8e76-caab1736afe7"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("d3900e7b-05d6-4dbb-bce9-869e139f87ef"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("d42bb942-0028-4220-93fa-a833818c05d2"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("deb4ff29-7f2f-4bbd-93fc-0ebf5791fb4d"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("e2da9965-5f07-4a16-b041-057f750e565b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("e32c7fe5-1046-45da-9f58-335f4c718278"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("e58ff9cc-f6c1-4083-bf54-2fc73118ab78"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("e89e1d07-3771-4fa6-be18-e8d027f3d709"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("ed797d7c-68c6-4535-b744-fb442cd3b688"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("ee90250e-80a6-4a65-b4eb-5e8a23dbe23b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("f1195d83-d908-42fd-9d2e-ecc92c052a8b"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("f11cb6f3-79ab-40f5-b79f-781997d1615a"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("fce39780-73a1-40df-b031-57f030ae9194"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("fd20cc30-878b-4e52-bde2-7cf6e68580c0"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("fdf71da4-08e9-4bda-ae2e-7843e3734d24"));

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: new Guid("ff6f56d7-f621-4603-9c8e-9a6c26170ea2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00b8ca46-d75e-42a7-8c58-0ac359bcfe9a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11a89bf3-7492-4b6b-b5b3-c7cffb975c76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("274528b2-766c-47cf-a3ac-8fdd9dbb4075"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f0803da-9e69-464d-9f13-79b9809400d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3717b5f4-25f5-4c82-b8aa-315b729a9b47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c0152ba-89da-4e3b-959d-4fc91f489e5d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c40278b-4669-44b4-b774-056d2656fe6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7dacdc85-099c-4541-93cd-e719d10fa890"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3cff413-5927-4679-9fcc-74d8789909fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ac352259-92e9-463c-81be-2171ae4e30d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bab4ac2f-9804-4793-b9dc-133995603984"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf127fd6-8a89-4013-9a14-11a115f4f4b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7994de5-3dbc-486a-a92b-138321f56b71"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("d0e7ea7d-2b41-4337-b8a8-e802781d06c3"), "Ukraine" },
                    { new Guid("ddaec68c-1e86-4484-9991-c5bb51717f63"), "Germany" },
                    { new Guid("09a33005-a5d6-4b58-a1bb-f9bce32bcd6d"), "Great Britain" },
                    { new Guid("a17c6af4-0389-4f80-b8c6-5b4d33d92a55"), "Poland" },
                    { new Guid("20c86b9b-f215-463f-a270-e4aebf24fb5f"), "France" },
                    { new Guid("36c40a62-0fec-4cb2-8984-13524bd35a0a"), "Czech Republic" },
                    { new Guid("f2167dda-a8bf-4089-8059-48f9a695d607"), "Australia" },
                    { new Guid("8f9ca5ca-fb1b-4c66-b33b-452d2fb60836"), "USA" },
                    { new Guid("c9910972-5213-4838-aaa5-102cf9bd3d24"), "Canada" },
                    { new Guid("44129eaf-0308-4f46-a526-3a2c72861361"), "Brazil" },
                    { new Guid("52038083-28db-4f1d-84e7-e021db13dc73"), "India" },
                    { new Guid("8b274d46-9afd-4117-a238-44a4222aa674"), "China" },
                    { new Guid("f5efc73d-00d4-452c-be64-b215bb743138"), "Japonia" }
                });
        }
    }
}
