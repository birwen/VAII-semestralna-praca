(function () {
	if (!localStorage.getItem('cookieconsent')) {
		document.body.innerHTML += '\
		<div class="cookieconsent" style="position:fixed;padding:20px;left:0;bottom:0;background-color:#000;color:#FFF;text-align:center;width:100%;z-index:99999;">\
			This site uses cookies. By continuing to use this website, you agree to their use. \
			<a href="#" style="color:#CCCCCC;">I Understand</a>\
		</div>\
		';
		document.querySelector('.cookieconsent a').onclick = function (e) {
			e.preventDefault();
			document.querySelector('.cookieconsent').style.display = 'none';
			localStorage.setItem('cookieconsent', true);
		};
	}
});

function readSingleFile(e) {
	var file = e.target.files[0];
	if (!file) {
		return;
	}
	var reader = new FileReader();
	reader.onload = function (e) {
		var contents = e.target.result;
		// Display file content
		displayContents(contents);
	};
	reader.readAsText(file);
}

function displayContents(contents) {
	var element = document.getElementById('file-content');
	element.setAttribute('value', contents);
}

document.getElementById('file-input').addEventListener('change', readSingleFile, false);
