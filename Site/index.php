<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link rel="stylesheet" media="screen" type="text/css" title="style"
	href="style.css" />
<title>PocketQueue</title>
<script type="text/javascript" src="jquery-2.1.1.min.js"></script>
</head>

<body>
	<div id="holder">
		<!--BEGIN OF TERMS OF USE. DO NOT EDIT OR DELETE THESE LINES. IF YOU EDIT OR DELETE THESE LINES AN ALERT MESSAGE MAY APPEAR WHEN TEMPLATE WILL BE ONLINE-->
		<div id="footer_terms">
			<h1>
				<strong>PocketQueue</strong> no <a
					href="http://www.layouts-templates.com/"><strong>PocketQueue</strong></a>
			</h1>
		</div>
		<!--END OF TERMS OF USE-->
		<!-- HEADER -->
		<div id="header">
			<a href="index.html">
		
		</div>
		<img src="images/LogoPocketqueue2.jpg" alt="logo" width="150"
			height="140" />
		<div id="letra">PocketQueue</div>
		<!-- END HEADER -->
		<div id="shadow">

			<!-- MENU -->
			<ul id="menu">

			</ul>
			<div class="clear"></div>
			<!-- END MENU -->
			<!-- EDITO -->
			<form id="form1">
				<div id="edito">
					</a>
					<h2>Senha:</h2>
					<div id="editletra">
						<p>
							--Por aqui para visualizar a senha--
							<p>
					
					</div>
					
					<div id="emAtendimento" class="emAtendimento chamada" >
						<ul></ul> 
					</div>
					
				 	<div id="jaAtendido" class="jaAtendido chamada">
				 		<ul>
				 		</ul>
					</div>
					<input type="submit" name="submit" id="submit"
						value="Atualizar senha" />
				</div>
			</form>
			<!-- END EDITO -->
			<div id="toal"></div>
			<!-- CONTENT -->

			<div id="content">
				<!-- ABOUT ME -->
				<div>
					<h1>Sobre nosso ServiÃ§o</h1>
					<p>
						<em>Acesse sua senha pelo seu celular</em><br>Por meio do nosso
							site nossos usuarios possuem acesso em qualquer lugar e a
							qualquer momento as atualizaÃ§Ãµes de senhas de GuichÃª,o o
							cliente podera ficar tranquilo sem se preoculpar de perder sua
							vez na fila. 
					
					</p>
					<p></p>
				</div>


				<div id="vertical_barr">
					<h1>Texto</h1>
					<p>
						<em>9/10/2014</em><strong>textotextotextotexto</strong>
					</p>
					<p>
						<a href="#">textotextotextotexto</a>
					</p>
					<p>
						<em>9/10/2014</em><strong>textotextotextotexto</strong>
					</p>
					<p>
						<a href="#">textotextotextotexto</a>
					</p>

				</div>


				<div>
					<h1>Texto</h1>

					<ul>
						<li><a href="#">Texto</a></li>
						<li><a href="#">Texto</a></li>

					</ul>

				</div>

			</div>

			<div class="clear"></div>

		</div>

		<div id="footer">
			<p>
				Contato <a href="#">(xx)-(xxxx-xxxx)</a>
			</p>
		</div>

	</div>

</body>
<script>
        $('#form1').submit(function(event) {
                event.preventDefault();
                $.ajax({
                    type: 'POST',
                    url: 'Senhas.php',
                    data: $(this).serialize(),
                    dataType: 'json',
                    success: function (data){
						var selector = null;
						$("div#jaAtendido ul, div#emAtendimento ul").empty();
                    	$.each(data, function(i, item) {
                    		selector = null;
                        	if(item.estadoSenha == 4){
                        		selector = "div#jaAtendido > ul";
                            }else if(item.estadoSenha == 3){
                            	selector = "div#emAtendimento > ul";
                            }

                            if(selector != null){
                                console.debug(i)
                        		$(selector).append("<li><ul><li>Senha: "+item.senha+"</li><li>Guichê: "+item.guiche+"</li></ul></li>");
                            }
                    	});
                    }
            });
        });
        </script>
</html>
